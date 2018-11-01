using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModLab1
{
    public partial class Result : Form
    {
        private const int k = 20;
        private const int n = 1000000;

        public Result()
        {
            InitializeComponent();

            a.Text = Convert.ToString(134279);
            m.Text = Convert.ToString(313107);
            R0.Text = Convert.ToString(1);
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(this.a.Text);
            int r0 = Convert.ToInt32(this.R0.Text);
            int m = Convert.ToInt32(this.m.Text);

            var xn = Generate(n, r0, a, m);

            double mato = xn.Sum() / n;

            double disp = ((double) n / (n - 1)) *( xn.Sum(i=> Math.Pow(i, 2) - Math.Pow(mato, 2)) / n);

            double qu = Math.Sqrt(disp > 0 ? disp : disp * (-1));

            double xmin = xn.Min();
            double xmax = xn.Max();

            double rvar = xmax - xmin;
            double delta = rvar / k;

            var coefficients = new Dictionary<double, int>();

            for (int i = 1; i <= k; i++)
            {
                if (i == k)
                {
                    coefficients.Add(xmin + (i * delta), xn.Where(xni => xni >= ((i - 1) * delta) + xmin).ToList().Count());
                    break;
                }
                coefficients.Add(xmin + (i * delta), xn.Where(xni => xni < (i * delta) + xmin && xni >= ((i - 1) * delta) + xmin).ToList().Count());
            }

            var frequency = new Dictionary<double, double>();

            foreach (var coef in coefficients)
            {
                frequency.Add(coef.Key,(double)coef.Value/n);
            }

            DrawChannelHistograms(frequency, k, delta, xmin);

            double K = GetK(xn);
            double tempK = 2 * K / n;
            cheak.Text = $@"(2/n)*K = ({2}/{n})*{K} = {tempK} -> П/4";

            double xv = xn.Last();

            int p = GetP(xn, xv);
            int l = GetL(xn, p);
            double xp = xn[p];

            showm.Text = $@"m = {mato}";
            showd.Text = $@"D = {disp}";
            showq.Text = $@"q = {qu}";
            showp.Text = $@"P = {p}";
            showl.Text = $@"L = {l}";
        }

        private List<double> Generate(int n, double r0, int a, int m)
        {
            var Rn = new List<double> { r0 };
            var xn = new List<double>();

            for (int i = 0; i < n; i++)
            {
                Rn.Add(Generate(a, Rn.Last(), m));
                xn.Add(Rn.Last() / m);
            }

            return xn;
        }

        private double Generate(int a, double r, int m)
        {
            double temp = a * r;
            return temp % m;
        }

        private double GetK(IReadOnlyList<double> xn)
        {
            int k = 0;
            for (int i = 0; i < xn.Count - 1; i+=2)
            {
                if (Math.Pow(xn[i], 2) + Math.Pow(xn[i + 1], 2) < 1)
                {
                    k++;
                }
            }

            return k;
        }

        private int GetL(IReadOnlyList<double> xn, int p)
        {
            for (int i = 0; i < xn.Count - p; i += 2)
            {
                if (Equals(xn[i], xn[i+p]))
                {
                    return i + p;
                }
            }

            return 0;
        }


        private int GetP(IReadOnlyList<double> xn, double xv)
        {
            int count = 0;
            int i1 = 0;
            int i2 = 0;
            
            for (int i = 0; i < xn.Count; i ++)
            {
                if (count >= 2)
                    break;

                if (Equals(xv, xn[i]) && count == 0)
                {
                    i1 = i;
                    count++;
                    continue;
                }

                if (Equals(xv, xn[i]) && count == 1)
                {
                    i2 = i;
                    count++;
                }
            }

            return i2 - i1;
        }
        
        private void DrawChannelHistograms(Dictionary<double, double> frequency, int k, double delta, double xmin)
        {
            originalHistoR.Series["R"].Points.Clear();

            for (int i = 1; i <= k; i++)
            {
                originalHistoR.Series["R"].Points.AddXY((i * delta) + xmin, frequency[xmin + (i * delta)]);
            }
        }
    }
}
