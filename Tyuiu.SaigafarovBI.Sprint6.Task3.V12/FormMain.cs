using Tyuiu.SaigafarovBI.Sprint6.Task3.V12.Lib;

namespace Tyuiu.SaigafarovBI.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        int[,] matrix = new int[,]
            {
                {-6, -13,  -1,  -7,  10},

                {14, -18,  18,   1,  11},

                {-2, -17, -15, -10,  -8},

                {19,  -4,  -6, -11,   8},

                {-17,  17,  14,  13,  19}
            };
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            matrix = dataService.Calculate(matrix);
            dataGridView_SBI.ColumnCount = columns;
            dataGridView_SBI.RowCount = rows;
            for(int i = 0; i < columns; i++)
            {
                dataGridView_SBI.Columns[i].Width = 25;
            }
            for(int i = 0;i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    dataGridView_SBI.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
                
        }
        private void buttonHelp_SBI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПКТб-24-1 Сайгафаров Богдан Ирекович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
