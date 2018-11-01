using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ModLab2
{
    public partial class Result : Form
    {
        private const int K = 20;
        private const int N = 1000000;

        private int A, M, R0;
        private int Ny;
        private double Rn_1, Rn, mx, sx, Ly, a, b;

        public Result()
        {
            InitializeComponent();

            AValue.Text = Convert.ToString(134279);
            MValue.Text = Convert.ToString(313107);
            R0Value.Text = Convert.ToString(1);
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            var random = new List<double>();
            A = Convert.ToInt32(AValue.Text);
            M = Convert.ToInt32(MValue.Text);
            R0 = Convert.ToInt32(R0Value.Text);
            a = Convert.ToDouble(a_value.Text);
            b = Convert.ToDouble(b_value.Text);
            mx = Convert.ToDouble(mxTextbox.Text);
            sx = Convert.ToDouble(sxTextBox.Text);
            Ly = Convert.ToDouble(lyTextBox.Text);
            Ny = Convert.ToInt32(nuTextBox.Text);

            Rn = R0;
            for (int i = 0; i < N; i++)
            {
                double temp = UniformDistribution();
                random.Add(temp);
            }
            CalcEstimationsUniformDistribution(random, mValue1, DValue1, qValue1);
            DrawHistogram(random, originalHistoR);
            random.Clear();

            Rn = R0;
            for (int i = 0; i < N; i++)
            {
                double temp = GaussianDistribution();
                random.Add(temp);
            }
            CalcEstimations(random, textBox3, textBox2, textBox1);
            DrawHistogram(random, chart1);
            random.Clear();

            Rn = R0;
            for (int i = 0; i < N; i++)
            {
                double temp = ExponentialDistribution();
                random.Add(temp);
            }
            CalcEstimationsExponentialDistribution(random, textBox6, textBox5, textBox4);
            DrawHistogram(random, chart2);
            random.Clear();

            Rn = R0;
            for (int i = 0; i < N; i++)
            {
                double temp = GammalDistribution();
                random.Add(temp);
            }
            CalcEstimationsGammalDistribution(random, textBox9, textBox8, textBox7);
            DrawHistogram(random, chart3);
            random.Clear();

            Rn = R0;
            for (int i = 0; i < N; i++)
            {
                double temp = TriangleDistribution();
                random.Add(temp);
            }
            CalcEstimations(random, textBox12, textBox11, textBox10);
            DrawHistogram(random, chart4);
            random.Clear();

            Rn = R0;
            for (int i = 0; i < N; i++)
            {
                double temp = SimpsonDistribution();
                random.Add(temp);
            }
            CalcEstimations(random, textBox15, textBox14, textBox13);
            DrawHistogram(random, chart5);
            random.Clear();
        }

        private void DrawHistogram(IList<double> xn, Chart chart)
        {
            double xmin = xn.Min();
            double xmax = xn.Max();

            double rvar = xmax - xmin;
            double delta = rvar / K;

            var coefficients = new Dictionary<double, int>();

            for (int i = 1; i <= K; i++)
            {
                if (i == K)
                {
                    coefficients.Add(xmin + (i * delta), xn.Where(xni => xni >= ((i - 1) * delta) + xmin).ToList().Count());
                    break;
                }
                coefficients.Add(xmin + (i * delta), xn.Where(xni => xni < (i * delta) + xmin && xni >= ((i - 1) * delta) + xmin).ToList().Count());
            }

            var frequency = new Dictionary<double, double>();

            foreach (var coef in coefficients)
            {
                frequency.Add(coef.Key, (double)coef.Value / N);
            }

            DrawChannelHistograms(frequency, K, delta, xmin, chart);
        }
        
        private void DrawChannelHistograms(IReadOnlyDictionary<double, double> frequency, int k, 
            double delta, double xmin, Chart chart)
        {
            chart.Series["R"].Points.Clear();

            for (int i = 1; i <= k; i++)
            {
                chart.Series["R"].Points.AddXY((i * delta) + xmin, frequency[xmin + (i * delta)]);
            }
        }

        private double LehmerAlgorithm()
        {
            Rn_1 = Rn;
            Rn = (A * Rn_1) % M;
            return Rn / M;
        }

        //-------------------------------------------------

        private double UniformDistribution()
        {
            double R1 = LehmerAlgorithm();
            return a + (b - a) * R1;
        }

        private void CalcEstimationsUniformDistribution(List<double> Random, Control Mx_value,
            Control Dx_value, Control Sx_value)
        {
            double Mx = (a + b) / 2;

            double Dx = Math.Pow(b - a, 2) / 12;

            Mx_value.Text = Convert.ToString(Mx);
            Dx_value.Text = Convert.ToString(Dx);
            Sx_value.Text = Convert.ToString(Math.Sqrt(Dx));
        }

        //-------------------------------------------------

        private double GaussianDistribution()
        {
            var R1 = new List<double>();
            for (int i = 0; i < 12; i++)
            {
                R1.Add(LehmerAlgorithm());
            }

            return mx + sx * (R1.Sum() - 6);
        }

        //-------------------------------------------------

        private double ExponentialDistribution()
        {
            double R1 = LehmerAlgorithm();

            double X = (-1) * Math.Log(R1) / Ly;

            return X;
        }

        private void CalcEstimationsExponentialDistribution(List<double> Random,TextBox Mx_value,
            TextBox Dx_value, TextBox Sx_value)
        {
            double Mx = 0, Dx = 0;

            Mx = 1 / Ly;

            Dx = Math.Pow(Mx, 2);

            Mx_value.Text = Convert.ToString(Mx);
            Dx_value.Text = Convert.ToString(Dx);
            Sx_value.Text = Convert.ToString(Mx);
        }

        //-------------------------------------------------
        private double GammalDistribution()
        {
            var R1 = new List<double>();
            for (int i = 0; i < Ny; i++)
            {
                R1.Add(LehmerAlgorithm());
            }
            double sum = 0;

            for (int i = 0; i < Ny; i++)
            {
                sum += Math.Log(R1[i]);
            }
            double X = (-1) * sum / Ly;
            return X;
        }

        private void CalcEstimationsGammalDistribution(List<double> Random, Control Mx_value,
        Control Dx_value, Control Sx_value)
        {
            double Mx = Ny / Ly;

            double Dx = Ny / Math.Pow(Ly, 2);

            Mx_value.Text = Convert.ToString(Mx);
            Dx_value.Text = Convert.ToString(Dx);
            Sx_value.Text = Convert.ToString(Math.Sqrt(Dx));
        }

        //-------------------------------------------------

        private double SimpsonDistribution()
        {
            double R1 = LehmerAlgorithm();
            double R2 = LehmerAlgorithm();

            double X = (Math.Max(a, b) - Math.Min(a, b)) * (R1 + R2) / 2 + a;

            return X;
        }

        //-------------------------------------------------

        private double TriangleDistribution()
        {
            double R1 = LehmerAlgorithm();
            double R2 = LehmerAlgorithm();
            //double X = a + (b - a) * Math.Max(R1, R2);
            //if (right_button.Checked)
            //{
            //    X = a + (b - a) * Math.Max(R1, R2);
            //}
            //else
            //{
            //    X = a + (b - a) * Math.Min(R1, R2);
            //}

            return a + (b - a) * Math.Max(R1, R2); 
        }

        //-------------------------------------------------

        private void CalcEstimations(List<double> Random, TextBox Mx_value,
            TextBox Dx_value, TextBox Sx_value)
        {
            double Mx = 0, Dx = 0;

            for (int i = 0; i < N; i++)
            {
                Mx += Random[i];
            }

            Mx /= N;

            for (int i = 0; i < N; i++)
            {
                Dx += Math.Pow((Random[i] - Mx), 2);
            }

            Dx /= N - 1;

            Mx_value.Text = Convert.ToString(Mx);
            Dx_value.Text = Convert.ToString(Dx);
            Sx_value.Text = Convert.ToString(Math.Sqrt(Dx));
        }
    }
}
