namespace Tyuiu.SaigafarovBI.Sprint6.Task6.V7
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelButtons_SBI = new Panel();
            buttonHelp_SBI = new Button();
            buttonDone_SBI = new Button();
            buttonOpenFile_SBI = new Button();
            panel2 = new Panel();
            panelTask_SBI = new Panel();
            groupBoxTask_SBI = new GroupBox();
            textBoxTask_SBI = new TextBox();
            panel4 = new Panel();
            panelInput_SBI = new Panel();
            groupBoxInput_SBI = new GroupBox();
            textBoxInput_SBI = new TextBox();
            panelOutput_SBI = new Panel();
            groupBoxOutput_SBI = new GroupBox();
            textBoxOutput_SBI = new TextBox();
            splitter_SBI = new Splitter();
            toolTip_SBI = new ToolTip(components);
            openFileDialog_SBI = new OpenFileDialog();
            panelButtons_SBI.SuspendLayout();
            panelTask_SBI.SuspendLayout();
            groupBoxTask_SBI.SuspendLayout();
            panel4.SuspendLayout();
            panelInput_SBI.SuspendLayout();
            groupBoxInput_SBI.SuspendLayout();
            panelOutput_SBI.SuspendLayout();
            groupBoxOutput_SBI.SuspendLayout();
            SuspendLayout();
            // 
            // panelButtons_SBI
            // 
            panelButtons_SBI.BorderStyle = BorderStyle.Fixed3D;
            panelButtons_SBI.Controls.Add(buttonHelp_SBI);
            panelButtons_SBI.Controls.Add(buttonDone_SBI);
            panelButtons_SBI.Controls.Add(buttonOpenFile_SBI);
            panelButtons_SBI.Controls.Add(panel2);
            panelButtons_SBI.Dock = DockStyle.Top;
            panelButtons_SBI.Location = new Point(0, 0);
            panelButtons_SBI.Name = "panelButtons_SBI";
            panelButtons_SBI.Size = new Size(800, 68);
            panelButtons_SBI.TabIndex = 0;
            // 
            // buttonHelp_SBI
            // 
            buttonHelp_SBI.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_SBI.BackColor = Color.Transparent;
            buttonHelp_SBI.BackgroundImage = (Image)resources.GetObject("buttonHelp_SBI.BackgroundImage");
            buttonHelp_SBI.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp_SBI.Location = new Point(715, 3);
            buttonHelp_SBI.Name = "buttonHelp_SBI";
            buttonHelp_SBI.Size = new Size(78, 62);
            buttonHelp_SBI.TabIndex = 4;
            toolTip_SBI.SetToolTip(buttonHelp_SBI, "Открыть справку");
            buttonHelp_SBI.UseVisualStyleBackColor = false;
            buttonHelp_SBI.Click += buttonHelp_Click;
            // 
            // buttonDone_SBI
            // 
            buttonDone_SBI.BackColor = Color.Transparent;
            buttonDone_SBI.BackgroundImage = (Image)resources.GetObject("buttonDone_SBI.BackgroundImage");
            buttonDone_SBI.BackgroundImageLayout = ImageLayout.Stretch;
            buttonDone_SBI.Enabled = false;
            buttonDone_SBI.Location = new Point(87, 3);
            buttonDone_SBI.Name = "buttonDone_SBI";
            buttonDone_SBI.Size = new Size(78, 62);
            buttonDone_SBI.TabIndex = 3;
            toolTip_SBI.SetToolTip(buttonDone_SBI, "Выполняет поиск каждого третьего слова строки в результирующею строку");
            buttonDone_SBI.UseVisualStyleBackColor = false;
            buttonDone_SBI.Click += buttonDone_Click;
            // 
            // buttonOpenFile_SBI
            // 
            buttonOpenFile_SBI.BackColor = Color.Transparent;
            buttonOpenFile_SBI.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_SBI.BackgroundImage");
            buttonOpenFile_SBI.BackgroundImageLayout = ImageLayout.Stretch;
            buttonOpenFile_SBI.Location = new Point(3, 3);
            buttonOpenFile_SBI.Name = "buttonOpenFile_SBI";
            buttonOpenFile_SBI.Size = new Size(78, 62);
            buttonOpenFile_SBI.TabIndex = 2;
            toolTip_SBI.SetToolTip(buttonOpenFile_SBI, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonOpenFile_SBI.UseVisualStyleBackColor = false;
            buttonOpenFile_SBI.Click += buttonOpenFile_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 76);
            panel2.TabIndex = 1;
            // 
            // panelTask_SBI
            // 
            panelTask_SBI.Controls.Add(groupBoxTask_SBI);
            panelTask_SBI.Dock = DockStyle.Top;
            panelTask_SBI.Location = new Point(0, 68);
            panelTask_SBI.Name = "panelTask_SBI";
            panelTask_SBI.Padding = new Padding(5);
            panelTask_SBI.Size = new Size(800, 101);
            panelTask_SBI.TabIndex = 1;
            // 
            // groupBoxTask_SBI
            // 
            groupBoxTask_SBI.Controls.Add(textBoxTask_SBI);
            groupBoxTask_SBI.Dock = DockStyle.Fill;
            groupBoxTask_SBI.Location = new Point(5, 5);
            groupBoxTask_SBI.Name = "groupBoxTask_SBI";
            groupBoxTask_SBI.RightToLeft = RightToLeft.No;
            groupBoxTask_SBI.Size = new Size(790, 91);
            groupBoxTask_SBI.TabIndex = 0;
            groupBoxTask_SBI.TabStop = false;
            groupBoxTask_SBI.Text = "Условие:";
            // 
            // textBoxTask_SBI
            // 
            textBoxTask_SBI.BorderStyle = BorderStyle.None;
            textBoxTask_SBI.Dock = DockStyle.Fill;
            textBoxTask_SBI.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_SBI.Location = new Point(3, 19);
            textBoxTask_SBI.Multiline = true;
            textBoxTask_SBI.Name = "textBoxTask_SBI";
            textBoxTask_SBI.ReadOnly = true;
            textBoxTask_SBI.Size = new Size(784, 69);
            textBoxTask_SBI.TabIndex = 0;
            textBoxTask_SBI.Text = resources.GetString("textBoxTask_SBI.Text");
            // 
            // panel4
            // 
            panel4.Controls.Add(panelInput_SBI);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 169);
            panel4.Name = "panel4";
            panel4.Size = new Size(390, 281);
            panel4.TabIndex = 2;
            // 
            // panelInput_SBI
            // 
            panelInput_SBI.Controls.Add(groupBoxInput_SBI);
            panelInput_SBI.Dock = DockStyle.Left;
            panelInput_SBI.Location = new Point(0, 0);
            panelInput_SBI.Name = "panelInput_SBI";
            panelInput_SBI.Padding = new Padding(5);
            panelInput_SBI.Size = new Size(390, 281);
            panelInput_SBI.TabIndex = 3;
            // 
            // groupBoxInput_SBI
            // 
            groupBoxInput_SBI.Controls.Add(textBoxInput_SBI);
            groupBoxInput_SBI.Dock = DockStyle.Fill;
            groupBoxInput_SBI.Location = new Point(5, 5);
            groupBoxInput_SBI.Name = "groupBoxInput_SBI";
            groupBoxInput_SBI.Size = new Size(380, 271);
            groupBoxInput_SBI.TabIndex = 0;
            groupBoxInput_SBI.TabStop = false;
            groupBoxInput_SBI.Text = "Ввод:";
            // 
            // textBoxInput_SBI
            // 
            textBoxInput_SBI.BorderStyle = BorderStyle.None;
            textBoxInput_SBI.Dock = DockStyle.Fill;
            textBoxInput_SBI.Location = new Point(3, 19);
            textBoxInput_SBI.Multiline = true;
            textBoxInput_SBI.Name = "textBoxInput_SBI";
            textBoxInput_SBI.ReadOnly = true;
            textBoxInput_SBI.Size = new Size(374, 249);
            textBoxInput_SBI.TabIndex = 0;
            // 
            // panelOutput_SBI
            // 
            panelOutput_SBI.Controls.Add(groupBoxOutput_SBI);
            panelOutput_SBI.Dock = DockStyle.Right;
            panelOutput_SBI.Location = new Point(396, 169);
            panelOutput_SBI.Name = "panelOutput_SBI";
            panelOutput_SBI.Padding = new Padding(5);
            panelOutput_SBI.Size = new Size(404, 281);
            panelOutput_SBI.TabIndex = 3;
            // 
            // groupBoxOutput_SBI
            // 
            groupBoxOutput_SBI.Controls.Add(textBoxOutput_SBI);
            groupBoxOutput_SBI.Dock = DockStyle.Fill;
            groupBoxOutput_SBI.Location = new Point(5, 5);
            groupBoxOutput_SBI.Name = "groupBoxOutput_SBI";
            groupBoxOutput_SBI.Size = new Size(394, 271);
            groupBoxOutput_SBI.TabIndex = 0;
            groupBoxOutput_SBI.TabStop = false;
            groupBoxOutput_SBI.Text = "Вывод:";
            // 
            // textBoxOutput_SBI
            // 
            textBoxOutput_SBI.BorderStyle = BorderStyle.None;
            textBoxOutput_SBI.Dock = DockStyle.Fill;
            textBoxOutput_SBI.Location = new Point(3, 19);
            textBoxOutput_SBI.Multiline = true;
            textBoxOutput_SBI.Name = "textBoxOutput_SBI";
            textBoxOutput_SBI.ReadOnly = true;
            textBoxOutput_SBI.Size = new Size(388, 249);
            textBoxOutput_SBI.TabIndex = 0;
            // 
            // splitter_SBI
            // 
            splitter_SBI.Location = new Point(390, 169);
            splitter_SBI.Name = "splitter_SBI";
            splitter_SBI.Size = new Size(3, 281);
            splitter_SBI.TabIndex = 4;
            splitter_SBI.TabStop = false;
            // 
            // openFileDialog_SBI
            // 
            openFileDialog_SBI.FileName = "openFileDialog_SBI";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitter_SBI);
            Controls.Add(panelOutput_SBI);
            Controls.Add(panel4);
            Controls.Add(panelTask_SBI);
            Controls.Add(panelButtons_SBI);
            MinimumSize = new Size(816, 489);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 7 | Сайгафаров Б.И. ";
            panelButtons_SBI.ResumeLayout(false);
            panelTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.ResumeLayout(false);
            groupBoxTask_SBI.PerformLayout();
            panel4.ResumeLayout(false);
            panelInput_SBI.ResumeLayout(false);
            groupBoxInput_SBI.ResumeLayout(false);
            groupBoxInput_SBI.PerformLayout();
            panelOutput_SBI.ResumeLayout(false);
            groupBoxOutput_SBI.ResumeLayout(false);
            groupBoxOutput_SBI.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelButtons_SBI;
        private Panel panel2;
        private Button buttonOpenFile_SBI;
        private Panel panelTask_SBI;
        private Button buttonDone_SBI;
        private Button buttonHelp_SBI;
        private GroupBox groupBoxTask_SBI;
        private TextBox textBoxTask_SBI;
        private Panel panel4;
        private Panel panelInput_SBI;
        private Panel panelOutput_SBI;
        private GroupBox groupBoxInput_SBI;
        private TextBox textBoxInput_SBI;
        private GroupBox groupBoxOutput_SBI;
        private TextBox textBoxOutput_SBI;
        private Splitter splitter_SBI;
        private ToolTip toolTip_SBI;
        private OpenFileDialog openFileDialog_SBI;
    }
}
