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
            chart_SBI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            buttonOpen_SBI = new Button();
            buttonHelp_SBI = new Button();
            groupBoxTask_SBI = new GroupBox();
            textBoxTask_SBI = new TextBox();
            buttonDone_SBI = new Button();
            panel2 = new Panel();
            groupBoxOutPut_SBI = new GroupBox();
            dataGridView_SBI = new DataGridView();
            panel3 = new Panel();
            splitter1 = new Splitter();
            ((System.ComponentModel.ISupportInitialize)chart_SBI).BeginInit();
            panel1.SuspendLayout();
            groupBoxTask_SBI.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutPut_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SBI).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // chart_SBI
            // 
            chartArea1.Name = "ChartArea1";
            chart_SBI.ChartAreas.Add(chartArea1);
            chart_SBI.Location = new Point(9, 11);
            chart_SBI.Name = "chart_SBI";
            chart_SBI.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            chart_SBI.Series.Add(series1);
            chart_SBI.Size = new Size(612, 295);
            chart_SBI.TabIndex = 0;
            chart_SBI.Text = "chart1";
            chart_SBI.UseWaitCursor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(buttonOpen_SBI);
            panel1.Controls.Add(buttonHelp_SBI);
            panel1.Controls.Add(groupBoxTask_SBI);
            panel1.Controls.Add(buttonDone_SBI);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 100);
            panel1.TabIndex = 1;
            // 
            // buttonOpen_SBI
            // 
            buttonOpen_SBI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpen_SBI.BackColor = SystemColors.HotTrack;
            buttonOpen_SBI.Location = new Point(655, 12);
            buttonOpen_SBI.Name = "buttonOpen_SBI";
            buttonOpen_SBI.Size = new Size(81, 82);
            buttonOpen_SBI.TabIndex = 11;
            buttonOpen_SBI.Text = "Открыть файл";
            buttonOpen_SBI.UseVisualStyleBackColor = false;
            buttonOpen_SBI.Click += buttonOpen_Click;
            // 
            // buttonHelp_SBI
            // 
            buttonHelp_SBI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SBI.BackColor = SystemColors.MenuHighlight;
            buttonHelp_SBI.Location = new Point(742, 12);
            buttonHelp_SBI.Name = "buttonHelp_SBI";
            buttonHelp_SBI.Size = new Size(66, 82);
            buttonHelp_SBI.TabIndex = 10;
            buttonHelp_SBI.Text = "Справка";
            buttonHelp_SBI.UseVisualStyleBackColor = false;
            buttonHelp_SBI.Click += buttonHelp_Click;
            // 
            // groupBoxTask_SBI
            // 
            groupBoxTask_SBI.Controls.Add(textBoxTask_SBI);
            groupBoxTask_SBI.Location = new Point(3, 3);
            groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            groupBoxTask_SBI.Padding = new Padding(5);
            groupBoxTask_SBI.Size = new Size(539, 91);
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
            textBoxTask_SBI.Size = new Size(529, 65);
            textBoxTask_SBI.TabIndex = 0;
            textBoxTask_SBI.Text = "Прочитать данные из файла InPutFileTask5.txt. Вывести в dataGridView все элементы, равные 0. Построить диаграмму по этим значениям.\r\n\r\n\r\n";
            // 
            // buttonDone_SBI
            // 
            buttonDone_SBI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_SBI.BackColor = Color.Green;
            buttonDone_SBI.Location = new Point(548, 12);
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
            groupBoxOutPut_SBI.Controls.Add(dataGridView_SBI);
            groupBoxOutPut_SBI.Dock = DockStyle.Fill;
            groupBoxOutPut_SBI.Location = new Point(0, 0);
            groupBoxOutPut_SBI.Name = "groupBoxOutPut_SBI";
            groupBoxOutPut_SBI.Padding = new Padding(5);
            groupBoxOutPut_SBI.Size = new Size(200, 311);
            groupBoxOutPut_SBI.TabIndex = 0;
            groupBoxOutPut_SBI.TabStop = false;
            groupBoxOutPut_SBI.Text = "Вывод данных:";
            // 
            // dataGridView_SBI
            // 
            dataGridView_SBI.AllowUserToAddRows = false;
            dataGridView_SBI.AllowUserToDeleteRows = false;
            dataGridView_SBI.AllowUserToResizeColumns = false;
            dataGridView_SBI.AllowUserToResizeRows = false;
            dataGridView_SBI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SBI.ColumnHeadersVisible = false;
            dataGridView_SBI.Dock = DockStyle.Fill;
            dataGridView_SBI.Location = new Point(5, 21);
            dataGridView_SBI.Name = "dataGridView_SBI";
            dataGridView_SBI.ReadOnly = true;
            dataGridView_SBI.RowHeadersVisible = false;
            dataGridView_SBI.Size = new Size(190, 285);
            dataGridView_SBI.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(splitter1);
            panel3.Controls.Add(chart_SBI);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(624, 311);
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
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(824, 411);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(840, 450);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 24 | Сайгафаров Б.И. ";
            ((System.ComponentModel.ISupportInitialize)chart_SBI).EndInit();
            panel1.ResumeLayout(false);
            groupBoxTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutPut_SBI.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_SBI).EndInit();
            panel3.ResumeLayout(false);
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
        private TextBox textBoxTask_SBI;
        private Button buttonHelp_SBI;
        private Button buttonDone_SBI;
        private Button buttonOpen_SBI;
        private DataGridView dataGridView_SBI;
    }
}
