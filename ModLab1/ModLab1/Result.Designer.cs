namespace ModLab1
{
    partial class Result
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.originalHistoR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.m = new System.Windows.Forms.TextBox();
            this.lablem = new System.Windows.Forms.Label();
            this.R0 = new System.Windows.Forms.TextBox();
            this.labelR0 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.processButton = new System.Windows.Forms.Button();
            this.cheak = new System.Windows.Forms.Label();
            this.showp = new System.Windows.Forms.Label();
            this.showl = new System.Windows.Forms.Label();
            this.showm = new System.Windows.Forms.Label();
            this.showd = new System.Windows.Forms.Label();
            this.showq = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalHistoR)).BeginInit();
            this.SuspendLayout();
            // 
            // originalHistoR
            // 
            chartArea2.Name = "ChartArea1";
            this.originalHistoR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.originalHistoR.Legends.Add(legend2);
            this.originalHistoR.Location = new System.Drawing.Point(25, 88);
            this.originalHistoR.Name = "originalHistoR";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.LegendText = "R";
            series4.Name = "R";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.Legend = "Legend1";
            series5.Name = "G";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "B";
            this.originalHistoR.Series.Add(series4);
            this.originalHistoR.Series.Add(series5);
            this.originalHistoR.Series.Add(series6);
            this.originalHistoR.Size = new System.Drawing.Size(700, 393);
            this.originalHistoR.TabIndex = 10;
            this.originalHistoR.Text = "chart1";
            // 
            // m
            // 
            this.m.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m.Location = new System.Drawing.Point(437, 23);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(94, 34);
            this.m.TabIndex = 45;
            // 
            // lablem
            // 
            this.lablem.AutoSize = true;
            this.lablem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablem.Location = new System.Drawing.Point(398, 29);
            this.lablem.Name = "lablem";
            this.lablem.Size = new System.Drawing.Size(33, 29);
            this.lablem.TabIndex = 44;
            this.lablem.Text = "m";
            // 
            // R0
            // 
            this.R0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R0.Location = new System.Drawing.Point(247, 25);
            this.R0.Name = "R0";
            this.R0.Size = new System.Drawing.Size(94, 34);
            this.R0.TabIndex = 43;
            // 
            // labelR0
            // 
            this.labelR0.AutoSize = true;
            this.labelR0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR0.Location = new System.Drawing.Point(198, 28);
            this.labelR0.Name = "labelR0";
            this.labelR0.Size = new System.Drawing.Size(43, 29);
            this.labelR0.TabIndex = 42;
            this.labelR0.Text = "R0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "a";
            // 
            // a
            // 
            this.a.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a.Location = new System.Drawing.Point(52, 27);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 34);
            this.a.TabIndex = 40;
            // 
            // processButton
            // 
            this.processButton.Location = new System.Drawing.Point(620, 28);
            this.processButton.Name = "processButton";
            this.processButton.Size = new System.Drawing.Size(105, 34);
            this.processButton.TabIndex = 46;
            this.processButton.Text = "GO";
            this.processButton.UseVisualStyleBackColor = true;
            this.processButton.Click += new System.EventHandler(this.processButton_Click);
            // 
            // cheak
            // 
            this.cheak.AutoSize = true;
            this.cheak.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheak.Location = new System.Drawing.Point(32, 640);
            this.cheak.Name = "cheak";
            this.cheak.Size = new System.Drawing.Size(113, 29);
            this.cheak.TabIndex = 47;
            this.cheak.Text = "(2/N)*K =";
            // 
            // showp
            // 
            this.showp.AutoSize = true;
            this.showp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showp.Location = new System.Drawing.Point(32, 685);
            this.showp.Name = "showp";
            this.showp.Size = new System.Drawing.Size(49, 29);
            this.showp.TabIndex = 48;
            this.showp.Text = "P =";
            // 
            // showl
            // 
            this.showl.AutoSize = true;
            this.showl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showl.Location = new System.Drawing.Point(32, 727);
            this.showl.Name = "showl";
            this.showl.Size = new System.Drawing.Size(46, 29);
            this.showl.TabIndex = 49;
            this.showl.Text = "L =";
            // 
            // showm
            // 
            this.showm.AutoSize = true;
            this.showm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showm.Location = new System.Drawing.Point(32, 508);
            this.showm.Name = "showm";
            this.showm.Size = new System.Drawing.Size(53, 29);
            this.showm.TabIndex = 50;
            this.showm.Text = "m =";
            // 
            // showd
            // 
            this.showd.AutoSize = true;
            this.showd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showd.Location = new System.Drawing.Point(32, 554);
            this.showd.Name = "showd";
            this.showd.Size = new System.Drawing.Size(50, 29);
            this.showd.TabIndex = 51;
            this.showd.Text = "D =";
            // 
            // showq
            // 
            this.showq.AutoSize = true;
            this.showq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showq.Location = new System.Drawing.Point(32, 597);
            this.showq.Name = "showq";
            this.showq.Size = new System.Drawing.Size(47, 29);
            this.showq.TabIndex = 52;
            this.showq.Text = "q =";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 772);
            this.Controls.Add(this.showq);
            this.Controls.Add(this.showd);
            this.Controls.Add(this.showm);
            this.Controls.Add(this.showl);
            this.Controls.Add(this.showp);
            this.Controls.Add(this.cheak);
            this.Controls.Add(this.processButton);
            this.Controls.Add(this.m);
            this.Controls.Add(this.lablem);
            this.Controls.Add(this.R0);
            this.Controls.Add(this.labelR0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.a);
            this.Controls.Add(this.originalHistoR);
            this.Name = "Result";
            this.Text = "Result";
            ((System.ComponentModel.ISupportInitialize)(this.originalHistoR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart originalHistoR;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.Label lablem;
        private System.Windows.Forms.TextBox R0;
        private System.Windows.Forms.Label labelR0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.Button processButton;
        private System.Windows.Forms.Label cheak;
        private System.Windows.Forms.Label showp;
        private System.Windows.Forms.Label showl;
        private System.Windows.Forms.Label showm;
        private System.Windows.Forms.Label showd;
        private System.Windows.Forms.Label showq;
    }
}