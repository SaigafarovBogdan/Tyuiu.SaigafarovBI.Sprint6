using Tyuiu.SaigafarovBI.Sprint6.Task5.V24.Lib;

namespace WinFormsAppChart
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService();
        string path = Path.Combine(Path.GetTempPath(), Path.GetTempFileName());

        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridView_SBI.ColumnCount = 2;
            dataGridView_SBI.Columns[0].Width = 20;
            dataGridView_SBI.Columns[1].Width = 50;

            chart_SBI.ChartAreas[0].AxisX.Title = "��� X";
            chart_SBI.ChartAreas[0].AxisY.Title = "��� Y";
            chart_SBI.Series[0].Points.Clear();

            double[] valueArray = new double[dataService.Lenght];

            valueArray = dataService.LoadFromDataFile(path);

            for (int i = 0; i < valueArray.Length; i++)
            {
                dataGridView_SBI.Rows.Add(Convert.ToString(i), Convert.ToString(valueArray[i]));
                chart_SBI.Series[0].Points.AddXY(i, valueArray[i]);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("���� 5 �������� ������� ������ ����-24-1 ���������� ������ ��������", "���������", MessageBoxButtons.OK);
        }
        private void buttonOpen_Click(Object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
