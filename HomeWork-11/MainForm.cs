using HomeWork_12.Core.Classes.File_Explorer;
using HomeWork_12.Core.Classes.Folder_Explorer;
using HomeWork_12.Core.Classes.JsonTools;
using HomeWork_12.Core.Classes.Login;
using HomeWork_12.Core.Classes.Search_Engine;
using HomeWork_12.Core.Classes.SearchAndDeleteStudent;
using HomeWork_12.Core.Classes.Student;
using HomeWork_12.Core.Classes.Ui_Tools;
using HomeWork_12.Core.Classes.University;
using HomeWork_12.Core.Enums.ObjectType;
using System.DirectoryServices;

namespace HomeWork_11
{
    public partial class MainWND : Form
    {
        public MainWND()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (!UiTools.IsEmpty(searchBox)) return;
                SearchEngine.FindObject(ref serachResult, _universities, x => x.Students!);
                UiTools.Clear(searchBox);
            }
        }

        private void objectTypeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                UiTools.Clear(textBox_0, textBox_1, textBox_2, textBox_3, passwordBox, textBox_4);
                UiTools.ChangeType(ref objectTypeCombo, out _currentObjType);
                SettingInputFields();
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (CheckTheCorrectness())
                    CreateObject();
                UiTools.Clear(textBox_0, textBox_1, textBox_2, textBox_3, passwordBox, textBox_4);
            }
        }

        private void saveFilesBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                JsonTools.ToJson(_universities, FolderExplorer.GetPath(fileNameBox.Text ?? "NoName.json") ?? null!);
            }
        }

        private void readFileBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                try
                {
                    UiTools.AddToList(objectBox, JsonTools.ToObj<IEnumerable<University>>(FileExplorer.GetPath()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (!UiTools.IsEmpty(univNameForDelBox, studentNameForDelBox)) return;
                StudentSearchEngine.FindAndClearStudent(_universities, x => x.Name == univNameForDelBox.Text, Int32.Parse(studentNameForDelBox.Text));
                MessageBox.Show($"Success");
                UiTools.Clear(univNameForDelBox, studentNameForDelBox);
                UiTools.Clear([serachResult]);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (!UiTools.IsEmpty(emailLogBox, passLogBox)) return;
                try
                {
                    if (StudentLogin.Login(_students, emailLogBox.Text, passLogBox.Text))
                        MessageBox.Show("success :)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
