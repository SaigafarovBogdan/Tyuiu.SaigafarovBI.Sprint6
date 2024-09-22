using Tyuiu.SaigafarovBI.Sprint6.Task6.V7.Lib;

namespace Tyuiu.SaigafarovBI.Sprint6.Task6.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxOutput_SBI.ScrollBars = ScrollBars.Vertical;
            textBoxInput_SBI.ScrollBars = ScrollBars.Vertical;
        }
        string openFilePath;
        DataService dataService = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            textBoxOutput_SBI.Text = dataService.CollectTextFromFile("",openFilePath);
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            openFileDialog_SBI.ShowDialog();
            openFilePath = openFileDialog_SBI.FileName;
            try
            {
                textBoxInput_SBI.Text = File.ReadAllText(openFilePath);
                groupBoxInput_SBI.Text = groupBoxInput_SBI.Text + " " + openFileDialog_SBI.FileName;
                buttonDone_SBI.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Файл не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
