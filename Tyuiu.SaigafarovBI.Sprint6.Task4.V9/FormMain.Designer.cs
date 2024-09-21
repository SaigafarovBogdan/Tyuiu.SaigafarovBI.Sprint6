namespace WinFormsAppChart
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            chart_SBI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            buttonSave_SBI = new Button();
            buttonHelp_SBI = new Button();
            groupBoxInput_SBI = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            textBoxStopStep_SBI = new TextBox();
            textBoxStartStep_SBI = new TextBox();
            groupBoxTask_SBI = new GroupBox();
            textBoxTask_SBI = new TextBox();
            buttonDone_SBI = new Button();
            panel2 = new Panel();
            groupBoxOutPut_SBI = new GroupBox();
            textBoxResult_SBI = new TextBox();
            panel3 = new Panel();
            splitter1 = new Splitter();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)chart_SBI).BeginInit();
            panel1.SuspendLayout();
            groupBoxInput_SBI.SuspendLayout();
            groupBoxTask_SBI.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutPut_SBI.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // chart_SBI
            // 
            chartArea1.Name = "ChartArea1";
            chart_SBI.ChartAreas.Add(chartArea1);
            chart_SBI.Location = new Point(9, 11);
            chart_SBI.Name = "chart_SBI";
            chart_SBI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chart_SBI.Series.Add(series1);
            chart_SBI.Size = new Size(710, 295);
            chart_SBI.TabIndex = 0;
            chart_SBI.Text = "chart1";
            chart_SBI.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonSave_SBI);
            panel1.Controls.Add(buttonHelp_SBI);
            panel1.Controls.Add(groupBoxInput_SBI);
            panel1.Controls.Add(groupBoxTask_SBI);
            panel1.Controls.Add(buttonDone_SBI);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 100);
            panel1.TabIndex = 1;
            // 
            // buttonSave_SBI
            // 
            buttonSave_SBI.BackColor = SystemColors.HotTrack;
            buttonSave_SBI.Location = new Point(770, 12);
            buttonSave_SBI.Name = "buttonSave_SBI";
            buttonSave_SBI.Size = new Size(81, 82);
            buttonSave_SBI.TabIndex = 11;
            buttonSave_SBI.Text = "Сохранить";
            buttonSave_SBI.UseVisualStyleBackColor = false;
            buttonSave_SBI.Click += buttonSave_Click;
            // 
            // buttonHelp_SBI
            // 
            buttonHelp_SBI.BackColor = SystemColors.MenuHighlight;
            buttonHelp_SBI.Location = new Point(857, 12);
            buttonHelp_SBI.Name = "buttonHelp_SBI";
            buttonHelp_SBI.Size = new Size(66, 82);
            buttonHelp_SBI.TabIndex = 10;
            buttonHelp_SBI.Text = "Справка";
            buttonHelp_SBI.UseVisualStyleBackColor = false;
            buttonHelp_SBI.Click += buttonHelp_Click;
            // 
            // groupBoxInput_SBI
            // 
            groupBoxInput_SBI.Controls.Add(label2);
            groupBoxInput_SBI.Controls.Add(label3);
            groupBoxInput_SBI.Controls.Add(textBoxStopStep_SBI);
            groupBoxInput_SBI.Controls.Add(textBoxStartStep_SBI);
            groupBoxInput_SBI.Location = new Point(370, 3);
            groupBoxInput_SBI.Name = "groupBoxInput_SBI";
            groupBoxInput_SBI.Size = new Size(287, 91);
            groupBoxInput_SBI.TabIndex = 1;
            groupBoxInput_SBI.TabStop = false;
            groupBoxInput_SBI.Text = "Ввод данных";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 25);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 13;
            label2.Text = "Конец шага:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 25);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 11;
            label3.Text = "Старт шага:";
            // 
            // textBoxStopStep_SBI
            // 
            textBoxStopStep_SBI.Location = new Point(146, 43);
            textBoxStopStep_SBI.Name = "textBoxStopStep_SBI";
            textBoxStopStep_SBI.Size = new Size(128, 23);
            textBoxStopStep_SBI.TabIndex = 12;
            // 
            // textBoxStartStep_SBI
            // 
            textBoxStartStep_SBI.Location = new Point(12, 43);
            textBoxStartStep_SBI.Name = "textBoxStartStep_SBI";
            textBoxStartStep_SBI.Size = new Size(128, 23);
            textBoxStartStep_SBI.TabIndex = 10;
            // 
            // groupBoxTask_SBI
            // 
            groupBoxTask_SBI.Controls.Add(textBoxTask_SBI);
            groupBoxTask_SBI.Location = new Point(3, 3);
            groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            groupBoxTask_SBI.Padding = new Padding(5);
            groupBoxTask_SBI.Size = new Size(361, 91);
            groupBoxTask_SBI.TabIndex = 0;
            groupBoxTask_SBI.TabStop = false;
            groupBoxTask_SBI.Text = "Условие:";
            // 
            // textBoxTask_SBI
            // 
            textBoxTask_SBI.BackColor = Color.White;
            textBoxTask_SBI.BorderStyle = BorderStyle.None;
            textBoxTask_SBI.Dock = DockStyle.Fill;
            textBoxTask_SBI.Location = new Point(5, 21);
            textBoxTask_SBI.Multiline = true;
            textBoxTask_SBI.Name = "textBoxTask_SBI";
            textBoxTask_SBI.ReadOnly = true;
            textBoxTask_SBI.Size = new Size(351, 65);
            textBoxTask_SBI.TabIndex = 0;
            textBoxTask_SBI.Text = resources.GetString("textBoxTask_SBI.Text");
            // 
            // buttonDone_SBI
            // 
            buttonDone_SBI.BackColor = Color.Green;
            buttonDone_SBI.Location = new Point(663, 12);
            buttonDone_SBI.Name = "buttonDone_SBI";
            buttonDone_SBI.Size = new Size(101, 82);
            buttonDone_SBI.TabIndex = 9;
            buttonDone_SBI.Text = "Выполнить";
            buttonDone_SBI.UseVisualStyleBackColor = false;
            buttonDone_SBI.Click += buttonDone_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(groupBoxOutPut_SBI);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 311);
            panel2.TabIndex = 2;
            // 
            // groupBoxOutPut_SBI
            // 
            groupBoxOutPut_SBI.BackColor = Color.White;
            groupBoxOutPut_SBI.Controls.Add(textBoxResult_SBI);
            groupBoxOutPut_SBI.Dock = DockStyle.Fill;
            groupBoxOutPut_SBI.Location = new Point(0, 0);
            groupBoxOutPut_SBI.Name = "groupBoxOutPut_SBI";
            groupBoxOutPut_SBI.Padding = new Padding(5);
            groupBoxOutPut_SBI.Size = new Size(200, 311);
            groupBoxOutPut_SBI.TabIndex = 0;
            groupBoxOutPut_SBI.TabStop = false;
            groupBoxOutPut_SBI.Text = "Вывод:";
            // 
            // textBoxResult_SBI
            // 
            textBoxResult_SBI.BackColor = Color.White;
            textBoxResult_SBI.BorderStyle = BorderStyle.None;
            textBoxResult_SBI.Dock = DockStyle.Fill;
            textBoxResult_SBI.Location = new Point(5, 21);
            textBoxResult_SBI.Multiline = true;
            textBoxResult_SBI.Name = "textBoxResult_SBI";
            textBoxResult_SBI.ReadOnly = true;
            textBoxResult_SBI.Size = new Size(190, 285);
            textBoxResult_SBI.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(chart_SBI);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(731, 311);
            panel3.TabIndex = 3;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 311);
            splitter1.TabIndex = 1;
            splitter1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(224, 3);
            label1.Name = "label1";
            label1.Size = new Size(329, 25);
            label1.TabIndex = 2;
            label1.Text = "Функция 2x-3/(cos(x)-2x) + 5x - sin(x)";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 9 | Сайгафаров Б.И. ";
            ((System.ComponentModel.ISupportInitialize)chart_SBI).EndInit();
            panel1.ResumeLayout(false);
            groupBoxInput_SBI.ResumeLayout(false);
            groupBoxInput_SBI.PerformLayout();
            groupBoxTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutPut_SBI.ResumeLayout(false);
            groupBoxOutPut_SBI.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_SBI;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask_SBI;
        private GroupBox groupBoxOutPut_SBI;
        private TextBox textBoxResult_SBI;
        private GroupBox groupBoxInput_SBI;
        private TextBox textBoxTask_SBI;
        private Label label2;
        private Label label3;
        private TextBox textBoxStopStep_SBI;
        private TextBox textBoxStartStep_SBI;
        private Button buttonHelp_SBI;
        private Button buttonDone_SBI;
        private Button buttonSave_SBI;
        private Label label1;
    }
}
