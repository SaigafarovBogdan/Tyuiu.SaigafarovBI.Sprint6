using Tyuiu.SaigafarovBI.Sprint6.Task4.V9.Lib;

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

                double[] valueArray = dataService.GetMassFunction(startStep, stopStep);
                chart_SBI.ChartAreas[0].AxisX.Title = "Ось X";
                chart_SBI.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxResult_SBI.Text = "";
                for(int i = 0; i < valueArray.Length; i++)
                {
                    chart_SBI.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_SBI.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введены неверные данные " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ПКТб-24-1 Сайгафаров Богдан Ирекович", "Сообщение", MessageBoxButtons.OK);
        }
        private void buttonSave_Click(Object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_SBI.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + " сохранен успешно!\n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
