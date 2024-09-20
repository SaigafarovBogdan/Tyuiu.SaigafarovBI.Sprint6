namespace Tyuiu.SaigafarovBI.Sprint6.Task2.V27
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SBI = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SBI = new System.Windows.Forms.TextBox();
            this.groupBoxInput_SBI = new System.Windows.Forms.GroupBox();
            this.labelStopStep_SBI = new System.Windows.Forms.Label();
            this.textBoxStopStep_SBI = new System.Windows.Forms.TextBox();
            this.labelStartStep_SBI = new System.Windows.Forms.Label();
            this.textBoxStartStep_SBI = new System.Windows.Forms.TextBox();
            this.buttonHelp_SBI = new System.Windows.Forms.Button();
            this.buttonDone_SBI = new System.Windows.Forms.Button();
            this.groupBoxResult_SBI = new System.Windows.Forms.GroupBox();
            this.labelResult_SBI = new System.Windows.Forms.Label();
            this.chartResult_SBI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView_SBI = new System.Windows.Forms.DataGridView();
            this.w = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_SBI.SuspendLayout();
            this.groupBoxInput_SBI.SuspendLayout();
            this.groupBoxResult_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SBI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SBI)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SBI
            // 
            this.groupBoxTask_SBI.Controls.Add(this.textBoxTask_SBI);
            this.groupBoxTask_SBI.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            this.groupBoxTask_SBI.Size = new System.Drawing.Size(485, 308);
            this.groupBoxTask_SBI.TabIndex = 0;
            this.groupBoxTask_SBI.TabStop = false;
            this.groupBoxTask_SBI.Text = "Условие";
            // 
            // textBoxTask_SBI
            // 
            this.textBoxTask_SBI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_SBI.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SBI.Multiline = true;
            this.textBoxTask_SBI.Name = "textBoxTask_SBI";
            this.textBoxTask_SBI.ReadOnly = true;
            this.textBoxTask_SBI.Size = new System.Drawing.Size(473, 61);
            this.textBoxTask_SBI.TabIndex = 0;
            this.textBoxTask_SBI.Text = "Протабулировать функцию sin(x) + cos(2x)/2 - 1,5x на заданном диапозоне.\r\nРезульт" +
    "ат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInput_SBI
            // 
            this.groupBoxInput_SBI.Controls.Add(this.labelStopStep_SBI);
            this.groupBoxInput_SBI.Controls.Add(this.textBoxStopStep_SBI);
            this.groupBoxInput_SBI.Controls.Add(this.labelStartStep_SBI);
            this.groupBoxInput_SBI.Controls.Add(this.textBoxStartStep_SBI);
            this.groupBoxInput_SBI.Location = new System.Drawing.Point(12, 341);
            this.groupBoxInput_SBI.Name = "groupBoxInput_SBI";
            this.groupBoxInput_SBI.Size = new System.Drawing.Size(248, 84);
            this.groupBoxInput_SBI.TabIndex = 1;
            this.groupBoxInput_SBI.TabStop = false;
            this.groupBoxInput_SBI.Text = "Ввод данных";
            // 
            // labelStopStep_SBI
            // 
            this.labelStopStep_SBI.AutoSize = true;
            this.labelStopStep_SBI.Location = new System.Drawing.Point(143, 32);
            this.labelStopStep_SBI.Name = "labelStopStep_SBI";
            this.labelStopStep_SBI.Size = new System.Drawing.Size(69, 13);
            this.labelStopStep_SBI.TabIndex = 3;
            this.labelStopStep_SBI.Text = "Конец шага:";
            // 
            // textBoxStopStep_SBI
            // 
            this.textBoxStopStep_SBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStopStep_SBI.Location = new System.Drawing.Point(142, 51);
            this.textBoxStopStep_SBI.Name = "textBoxStopStep_SBI";
            this.textBoxStopStep_SBI.Size = new System.Drawing.Size(100, 29);
            this.textBoxStopStep_SBI.TabIndex = 2;
            this.textBoxStopStep_SBI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSteps_SBI_KeyPress);
            // 
            // labelStartStep_SBI
            // 
            this.labelStartStep_SBI.AutoSize = true;
            this.labelStartStep_SBI.Location = new System.Drawing.Point(7, 32);
            this.labelStartStep_SBI.Name = "labelStartStep_SBI";
            this.labelStartStep_SBI.Size = new System.Drawing.Size(67, 13);
            this.labelStartStep_SBI.TabIndex = 1;
            this.labelStartStep_SBI.Text = "Старт шага:";
            // 
            // textBoxStartStep_SBI
            // 
            this.textBoxStartStep_SBI.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStartStep_SBI.Location = new System.Drawing.Point(6, 51);
            this.textBoxStartStep_SBI.Name = "textBoxStartStep_SBI";
            this.textBoxStartStep_SBI.Size = new System.Drawing.Size(100, 29);
            this.textBoxStartStep_SBI.TabIndex = 0;
            this.textBoxStartStep_SBI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSteps_SBI_KeyPress);
            // 
            // buttonHelp_SBI
            // 
            this.buttonHelp_SBI.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_SBI.Location = new System.Drawing.Point(266, 341);
            this.buttonHelp_SBI.Name = "buttonHelp_SBI";
            this.buttonHelp_SBI.Size = new System.Drawing.Size(75, 84);
            this.buttonHelp_SBI.TabIndex = 2;
            this.buttonHelp_SBI.Text = "Справка";
            this.buttonHelp_SBI.UseVisualStyleBackColor = false;
            this.buttonHelp_SBI.Click += new System.EventHandler(this.buttonHelp_SBI_Click);
            // 
            // buttonDone_SBI
            // 
            this.buttonDone_SBI.BackColor = System.Drawing.Color.Green;
            this.buttonDone_SBI.Location = new System.Drawing.Point(347, 341);
            this.buttonDone_SBI.Name = "buttonDone_SBI";
            this.buttonDone_SBI.Size = new System.Drawing.Size(150, 84);
            this.buttonDone_SBI.TabIndex = 3;
            this.buttonDone_SBI.Text = "Выполнить";
            this.buttonDone_SBI.UseVisualStyleBackColor = false;
            this.buttonDone_SBI.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxResult_SBI
            // 
            this.groupBoxResult_SBI.Controls.Add(this.labelResult_SBI);
            this.groupBoxResult_SBI.Controls.Add(this.chartResult_SBI);
            this.groupBoxResult_SBI.Controls.Add(this.dataGridView_SBI);
            this.groupBoxResult_SBI.Location = new System.Drawing.Point(503, 12);
            this.groupBoxResult_SBI.Name = "groupBoxResult_SBI";
            this.groupBoxResult_SBI.Size = new System.Drawing.Size(616, 413);
            this.groupBoxResult_SBI.TabIndex = 4;
            this.groupBoxResult_SBI.TabStop = false;
            this.groupBoxResult_SBI.Text = "Вывод данных";
            // 
            // labelResult_SBI
            // 
            this.labelResult_SBI.AutoSize = true;
            this.labelResult_SBI.Location = new System.Drawing.Point(7, 21);
            this.labelResult_SBI.Name = "labelResult_SBI";
            this.labelResult_SBI.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SBI.TabIndex = 2;
            this.labelResult_SBI.Text = "Результат:";
            // 
            // chartResult_SBI
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResult_SBI.ChartAreas.Add(chartArea1);
            this.chartResult_SBI.Location = new System.Drawing.Point(141, 19);
            this.chartResult_SBI.Name = "chartResult_SBI";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            this.chartResult_SBI.Series.Add(series1);
            this.chartResult_SBI.Size = new System.Drawing.Size(469, 389);
            this.chartResult_SBI.TabIndex = 1;
            this.chartResult_SBI.Text = "chartResult_SBI";
            // 
            // dataGridView_SBI
            // 
            this.dataGridView_SBI.AllowUserToAddRows = false;
            this.dataGridView_SBI.AllowUserToDeleteRows = false;
            this.dataGridView_SBI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SBI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.w,
            this.Column2});
            this.dataGridView_SBI.Location = new System.Drawing.Point(6, 40);
            this.dataGridView_SBI.Name = "dataGridView_SBI";
            this.dataGridView_SBI.ReadOnly = true;
            this.dataGridView_SBI.RowHeadersVisible = false;
            this.dataGridView_SBI.Size = new System.Drawing.Size(128, 367);
            this.dataGridView_SBI.TabIndex = 0;
            // 
            // w
            // 
            this.w.HeaderText = "X";
            this.w.Name = "w";
            this.w.ReadOnly = true;
            this.w.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "F(X)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 50;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 432);
            this.Controls.Add(this.groupBoxResult_SBI);
            this.Controls.Add(this.buttonDone_SBI);
            this.Controls.Add(this.buttonHelp_SBI);
            this.Controls.Add(this.groupBoxInput_SBI);
            this.Controls.Add(this.groupBoxTask_SBI);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 26 | Сайгафаров Б.И. ";
            this.groupBoxTask_SBI.ResumeLayout(false);
            this.groupBoxTask_SBI.PerformLayout();
            this.groupBoxInput_SBI.ResumeLayout(false);
            this.groupBoxInput_SBI.PerformLayout();
            this.groupBoxResult_SBI.ResumeLayout(false);
            this.groupBoxResult_SBI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SBI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SBI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SBI;
        private System.Windows.Forms.TextBox textBoxTask_SBI;
        private System.Windows.Forms.GroupBox groupBoxInput_SBI;
        private System.Windows.Forms.TextBox textBoxStartStep_SBI;
        private System.Windows.Forms.Label labelStartStep_SBI;
        private System.Windows.Forms.Label labelStopStep_SBI;
        private System.Windows.Forms.TextBox textBoxStopStep_SBI;
        private System.Windows.Forms.Button buttonHelp_SBI;
        private System.Windows.Forms.Button buttonDone_SBI;
        private System.Windows.Forms.GroupBox groupBoxResult_SBI;
        private System.Windows.Forms.DataGridView dataGridView_SBI;
        private System.Windows.Forms.Label labelResult_SBI;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SBI;
        private System.Windows.Forms.DataGridViewTextBoxColumn w;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

