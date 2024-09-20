namespace Tyuiu.SaigafarovBI.Sprint6.Task3.V12
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
            textBoxTask_SBI = new TextBox();
            groupBoxTask_SBI = new GroupBox();
            dataGridView_SBI = new DataGridView();
            buttonHelp_SBI = new Button();
            groupBoxTask_SBI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SBI).BeginInit();
            SuspendLayout();
            // 
            // textBoxTask_SBI
            // 
            textBoxTask_SBI.BorderStyle = BorderStyle.None;
            textBoxTask_SBI.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_SBI.Location = new Point(11, 19);
            textBoxTask_SBI.Multiline = true;
            textBoxTask_SBI.Name = "textBoxTask_SBI";
            textBoxTask_SBI.ReadOnly = true;
            textBoxTask_SBI.Size = new Size(183, 144);
            textBoxTask_SBI.TabIndex = 0;
            textBoxTask_SBI.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n-6 -13  -1  -7  10\r\n  14 -18  18   1  11\r\n  -2 -17 -15 -10  -8\r\n  19  -4  -6 -11   8\r\n -17  17  14  13  19\r\n";
            // 
            // groupBoxTask_SBI
            // 
            groupBoxTask_SBI.Controls.Add(dataGridView_SBI);
            groupBoxTask_SBI.Controls.Add(textBoxTask_SBI);
            groupBoxTask_SBI.Location = new Point(12, 12);
            groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            groupBoxTask_SBI.Size = new Size(602, 296);
            groupBoxTask_SBI.TabIndex = 3;
            groupBoxTask_SBI.TabStop = false;
            groupBoxTask_SBI.Text = "Условие";
            // 
            // dataGridView_SBI
            // 
            dataGridView_SBI.AllowUserToAddRows = false;
            dataGridView_SBI.AllowUserToDeleteRows = false;
            dataGridView_SBI.AllowUserToResizeColumns = false;
            dataGridView_SBI.AllowUserToResizeRows = false;
            dataGridView_SBI.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_SBI.ColumnHeadersVisible = false;
            dataGridView_SBI.Location = new Point(313, 19);
            dataGridView_SBI.Name = "dataGridView_SBI";
            dataGridView_SBI.ReadOnly = true;
            dataGridView_SBI.RowHeadersVisible = false;
            dataGridView_SBI.Size = new Size(283, 267);
            dataGridView_SBI.TabIndex = 1;
            // 
            // buttonHelp_SBI
            // 
            buttonHelp_SBI.BackColor = SystemColors.MenuHighlight;
            buttonHelp_SBI.FlatStyle = FlatStyle.System;
            buttonHelp_SBI.Location = new Point(621, 267);
            buttonHelp_SBI.Name = "buttonHelp_SBI";
            buttonHelp_SBI.Size = new Size(43, 41);
            buttonHelp_SBI.TabIndex = 13;
            buttonHelp_SBI.Text = "?";
            buttonHelp_SBI.UseVisualStyleBackColor = false;
            buttonHelp_SBI.Click += buttonHelp_SBI_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 313);
            Controls.Add(buttonHelp_SBI);
            Controls.Add(groupBoxTask_SBI);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 12 | Сайгафаров Б.И. ";
            Load += FormMain_Load;
            groupBoxTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_SBI).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxTask_SBI;
        private GroupBox groupBoxTask_SBI;
        private DataGridView dataGridView_SBI;
        private Button buttonHelp_SBI;
    }
}
