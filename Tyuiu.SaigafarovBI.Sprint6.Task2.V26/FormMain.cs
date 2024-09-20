using Tyuiu.SaigafarovBI.Sprint6.Task2.V26.Lib;

namespace WinFormsAppChart
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService dataService = new DataService(); 
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_SBI.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_SBI.Text);

                int len = dataService.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);
                chartResult_SBI.Titles.Add("График функции sin(x) + cos(2x)/2 - 1,5x");

                chartResult_SBI.ChartAreas[0].AxisX.Title = "Ось X";
                chartResult_SBI.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    dataGridView_SBI.Rows.Add(Convert.ToString(startStep), valueArray[i]);
                    chartResult_SBI.Series[0].Points.AddXY(startStep,valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxSteps_SBI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '.') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_SBI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-24-1 Сайгафаров Богдан Ирекович", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
