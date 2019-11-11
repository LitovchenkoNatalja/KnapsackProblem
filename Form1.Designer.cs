namespace KnapsackProblem
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.findFileButton = new System.Windows.Forms.Button();
            this.defaultFileButton = new System.Windows.Forms.Button();
            this.FAHillClimbingButton = new System.Windows.Forms.Button();
            this.textBoxTotalC = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxShowFull = new System.Windows.Forms.CheckBox();
            this.textBoxResultC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxResultW = new System.Windows.Forms.TextBox();
            this.listBoxSelectedItems = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxMaxAttemps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.MultiStartHillClimbingButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDelta = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBoxObjDetails = new System.Windows.Forms.CheckBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // findFileButton
            // 
            this.findFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.findFileButton.Location = new System.Drawing.Point(711, 12);
            this.findFileButton.Name = "findFileButton";
            this.findFileButton.Size = new System.Drawing.Size(75, 23);
            this.findFileButton.TabIndex = 0;
            this.findFileButton.Text = "Find File";
            this.findFileButton.UseVisualStyleBackColor = false;
            this.findFileButton.Click += new System.EventHandler(this.findFileButton_Click);
            // 
            // defaultFileButton
            // 
            this.defaultFileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.defaultFileButton.Location = new System.Drawing.Point(792, 12);
            this.defaultFileButton.Name = "defaultFileButton";
            this.defaultFileButton.Size = new System.Drawing.Size(75, 23);
            this.defaultFileButton.TabIndex = 1;
            this.defaultFileButton.Text = "Default File";
            this.defaultFileButton.UseVisualStyleBackColor = false;
            this.defaultFileButton.Click += new System.EventHandler(this.defaultFileButton_Click);
            // 
            // FAHillClimbingButton
            // 
            this.FAHillClimbingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FAHillClimbingButton.Location = new System.Drawing.Point(7, 3);
            this.FAHillClimbingButton.Name = "FAHillClimbingButton";
            this.FAHillClimbingButton.Size = new System.Drawing.Size(144, 47);
            this.FAHillClimbingButton.TabIndex = 2;
            this.FAHillClimbingButton.Text = "First Ascend Hill Climbing";
            this.FAHillClimbingButton.UseVisualStyleBackColor = true;
            this.FAHillClimbingButton.Click += new System.EventHandler(this.FAHillClimbingButton_Click);
            // 
            // textBoxTotalC
            // 
            this.textBoxTotalC.Enabled = false;
            this.textBoxTotalC.Location = new System.Drawing.Point(421, 12);
            this.textBoxTotalC.Name = "textBoxTotalC";
            this.textBoxTotalC.Size = new System.Drawing.Size(256, 20);
            this.textBoxTotalC.TabIndex = 4;
            // 
            // textBoxN
            // 
            this.textBoxN.Enabled = false;
            this.textBoxN.Location = new System.Drawing.Point(55, 14);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(256, 20);
            this.textBoxN.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Knapsack max size";
            // 
            // checkBoxShowFull
            // 
            this.checkBoxShowFull.AutoSize = true;
            this.checkBoxShowFull.Checked = true;
            this.checkBoxShowFull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowFull.Location = new System.Drawing.Point(7, 56);
            this.checkBoxShowFull.Name = "checkBoxShowFull";
            this.checkBoxShowFull.Size = new System.Drawing.Size(102, 17);
            this.checkBoxShowFull.TabIndex = 8;
            this.checkBoxShowFull.Text = "Show full results";
            this.checkBoxShowFull.UseVisualStyleBackColor = true;
            // 
            // textBoxResultC
            // 
            this.textBoxResultC.Enabled = false;
            this.textBoxResultC.Location = new System.Drawing.Point(7, 92);
            this.textBoxResultC.Name = "textBoxResultC";
            this.textBoxResultC.Size = new System.Drawing.Size(144, 20);
            this.textBoxResultC.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Result Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Result Weight";
            // 
            // textBoxResultW
            // 
            this.textBoxResultW.Enabled = false;
            this.textBoxResultW.Location = new System.Drawing.Point(7, 131);
            this.textBoxResultW.Name = "textBoxResultW";
            this.textBoxResultW.Size = new System.Drawing.Size(144, 20);
            this.textBoxResultW.TabIndex = 12;
            // 
            // listBoxSelectedItems
            // 
            this.listBoxSelectedItems.FormattingEnabled = true;
            this.listBoxSelectedItems.Location = new System.Drawing.Point(7, 170);
            this.listBoxSelectedItems.Name = "listBoxSelectedItems";
            this.listBoxSelectedItems.Size = new System.Drawing.Size(144, 212);
            this.listBoxSelectedItems.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Selected items";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(923, 467);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.textBoxTotalC);
            this.tabPage1.Controls.Add(this.findFileButton);
            this.tabPage1.Controls.Add(this.defaultFileButton);
            this.tabPage1.Controls.Add(this.textBoxN);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(915, 441);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hill Climbing";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.checkBoxObjDetails);
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Controls.Add(this.textBoxDelta);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxMaxAttemps);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.MultiStartHillClimbingButton);
            this.panel2.Location = new System.Drawing.Point(179, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 395);
            this.panel2.TabIndex = 9;
            // 
            // textBoxMaxAttemps
            // 
            this.textBoxMaxAttemps.Location = new System.Drawing.Point(92, 52);
            this.textBoxMaxAttemps.Name = "textBoxMaxAttemps";
            this.textBoxMaxAttemps.Size = new System.Drawing.Size(259, 20);
            this.textBoxMaxAttemps.TabIndex = 17;
            this.textBoxMaxAttemps.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Max Attemps";
            // 
            // MultiStartHillClimbingButton
            // 
            this.MultiStartHillClimbingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MultiStartHillClimbingButton.Location = new System.Drawing.Point(3, 3);
            this.MultiStartHillClimbingButton.Name = "MultiStartHillClimbingButton";
            this.MultiStartHillClimbingButton.Size = new System.Drawing.Size(480, 47);
            this.MultiStartHillClimbingButton.TabIndex = 15;
            this.MultiStartHillClimbingButton.Text = "Multi Start Hill Climbing";
            this.MultiStartHillClimbingButton.UseVisualStyleBackColor = true;
            this.MultiStartHillClimbingButton.Click += new System.EventHandler(this.MultiStartHillClimbingButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.textBoxResultW);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FAHillClimbingButton);
            this.panel1.Controls.Add(this.listBoxSelectedItems);
            this.panel1.Controls.Add(this.checkBoxShowFull);
            this.panel1.Controls.Add(this.textBoxResultC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(6, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 395);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "delta";
            // 
            // textBoxDelta
            // 
            this.textBoxDelta.Enabled = false;
            this.textBoxDelta.Location = new System.Drawing.Point(429, 52);
            this.textBoxDelta.Name = "textBoxDelta";
            this.textBoxDelta.Size = new System.Drawing.Size(259, 20);
            this.textBoxDelta.TabIndex = 20;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(3, 72);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(724, 320);
            this.tabControl2.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(716, 294);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Statistics";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(716, 294);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Objective";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea4.AxisX.Interval = 1D;
            chartArea4.Name = "Area1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(6, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(704, 282);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // checkBoxObjDetails
            // 
            this.checkBoxObjDetails.AutoSize = true;
            this.checkBoxObjDetails.Location = new System.Drawing.Point(489, 19);
            this.checkBoxObjDetails.Name = "checkBoxObjDetails";
            this.checkBoxObjDetails.Size = new System.Drawing.Size(188, 17);
            this.checkBoxObjDetails.TabIndex = 21;
            this.checkBoxObjDetails.Text = "Include objective iteration function";
            this.checkBoxObjDetails.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea3.Name = "Area1";
            this.chart2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart2.Legends.Add(legend3);
            this.chart2.Location = new System.Drawing.Point(3, 6);
            this.chart2.Name = "chart2";
            series2.ChartArea = "Area1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Objective";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(707, 285);
            this.chart2.TabIndex = 0;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 491);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findFileButton;
        private System.Windows.Forms.Button defaultFileButton;
        private System.Windows.Forms.Button FAHillClimbingButton;
        private System.Windows.Forms.TextBox textBoxTotalC;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxShowFull;
        private System.Windows.Forms.TextBox textBoxResultC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxResultW;
        private System.Windows.Forms.ListBox listBoxSelectedItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MultiStartHillClimbingButton;
        private System.Windows.Forms.TextBox textBoxMaxAttemps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDelta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.CheckBox checkBoxObjDetails;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}

