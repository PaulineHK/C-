namespace _4_1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.boxXmin = new System.Windows.Forms.TextBox();
            this.boxXmax = new System.Windows.Forms.TextBox();
            this.boxStep = new System.Windows.Forms.TextBox();
            this.boxA = new System.Windows.Forms.TextBox();
            this.boxB = new System.Windows.Forms.TextBox();
            this.boxC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lXmin = new System.Windows.Forms.Label();
            this.lXmax = new System.Windows.Forms.Label();
            this.lStep = new System.Windows.Forms.Label();
            this.lA = new System.Windows.Forms.Label();
            this.lB = new System.Windows.Forms.Label();
            this.lC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(122, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.EmptyPointStyle.BorderWidth = 15;
            series1.EmptyPointStyle.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.Name = "y(x)";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(422, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // boxXmin
            // 
            this.boxXmin.Location = new System.Drawing.Point(37, 327);
            this.boxXmin.Name = "boxXmin";
            this.boxXmin.Size = new System.Drawing.Size(100, 20);
            this.boxXmin.TabIndex = 2;
            this.boxXmin.TextChanged += new System.EventHandler(this.boxXmin_TextChanged);
            // 
            // boxXmax
            // 
            this.boxXmax.Location = new System.Drawing.Point(185, 328);
            this.boxXmax.Name = "boxXmax";
            this.boxXmax.Size = new System.Drawing.Size(100, 20);
            this.boxXmax.TabIndex = 3;
            this.boxXmax.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // boxStep
            // 
            this.boxStep.Location = new System.Drawing.Point(331, 329);
            this.boxStep.Name = "boxStep";
            this.boxStep.Size = new System.Drawing.Size(100, 20);
            this.boxStep.TabIndex = 4;
            this.boxStep.TextChanged += new System.EventHandler(this.boxStep_TextChanged);
            // 
            // boxA
            // 
            this.boxA.Location = new System.Drawing.Point(16, 72);
            this.boxA.Name = "boxA";
            this.boxA.Size = new System.Drawing.Size(100, 20);
            this.boxA.TabIndex = 5;
            this.boxA.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // boxB
            // 
            this.boxB.Location = new System.Drawing.Point(16, 110);
            this.boxB.Name = "boxB";
            this.boxB.Size = new System.Drawing.Size(100, 20);
            this.boxB.TabIndex = 6;
            this.boxB.TextChanged += new System.EventHandler(this.boxB_TextChanged);
            // 
            // boxC
            // 
            this.boxC.Location = new System.Drawing.Point(16, 149);
            this.boxC.Name = "boxC";
            this.boxC.Size = new System.Drawing.Size(100, 20);
            this.boxC.TabIndex = 7;
            this.boxC.TextChanged += new System.EventHandler(this.boxC_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Xmin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Xmax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Шаг:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "a:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "b:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "c:";
            // 
            // lXmin
            // 
            this.lXmin.AutoSize = true;
            this.lXmin.Location = new System.Drawing.Point(40, 350);
            this.lXmin.Name = "lXmin";
            this.lXmin.Size = new System.Drawing.Size(81, 13);
            this.lXmin.TabIndex = 14;
            this.lXmin.Text = "Введите число";
            // 
            // lXmax
            // 
            this.lXmax.AutoSize = true;
            this.lXmax.Location = new System.Drawing.Point(193, 350);
            this.lXmax.Name = "lXmax";
            this.lXmax.Size = new System.Drawing.Size(81, 13);
            this.lXmax.TabIndex = 15;
            this.lXmax.Text = "Введите число";
            // 
            // lStep
            // 
            this.lStep.AutoSize = true;
            this.lStep.Location = new System.Drawing.Point(340, 350);
            this.lStep.Name = "lStep";
            this.lStep.Size = new System.Drawing.Size(81, 13);
            this.lStep.TabIndex = 16;
            this.lStep.Text = "Введите число";
            // 
            // lA
            // 
            this.lA.AutoSize = true;
            this.lA.Location = new System.Drawing.Point(22, 94);
            this.lA.Name = "lA";
            this.lA.Size = new System.Drawing.Size(81, 13);
            this.lA.TabIndex = 17;
            this.lA.Text = "Введите число";
            // 
            // lB
            // 
            this.lB.AutoSize = true;
            this.lB.Location = new System.Drawing.Point(22, 133);
            this.lB.Name = "lB";
            this.lB.Size = new System.Drawing.Size(81, 13);
            this.lB.TabIndex = 18;
            this.lB.Text = "Введите число";
            // 
            // lC
            // 
            this.lC.AutoSize = true;
            this.lC.Location = new System.Drawing.Point(22, 172);
            this.lC.Name = "lC";
            this.lC.Size = new System.Drawing.Size(81, 13);
            this.lC.TabIndex = 19;
            this.lC.Text = "Введите число";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 372);
            this.Controls.Add(this.lC);
            this.Controls.Add(this.lB);
            this.Controls.Add(this.lA);
            this.Controls.Add(this.lStep);
            this.Controls.Add(this.lXmax);
            this.Controls.Add(this.lXmin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxC);
            this.Controls.Add(this.boxB);
            this.Controls.Add(this.boxA);
            this.Controls.Add(this.boxStep);
            this.Controls.Add(this.boxXmax);
            this.Controls.Add(this.boxXmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox boxXmin;
        private System.Windows.Forms.TextBox boxXmax;
        private System.Windows.Forms.TextBox boxStep;
        private System.Windows.Forms.TextBox boxA;
        private System.Windows.Forms.TextBox boxB;
        private System.Windows.Forms.TextBox boxC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lXmin;
        private System.Windows.Forms.Label lXmax;
        private System.Windows.Forms.Label lStep;
        private System.Windows.Forms.Label lA;
        private System.Windows.Forms.Label lB;
        private System.Windows.Forms.Label lC;
    }
}

