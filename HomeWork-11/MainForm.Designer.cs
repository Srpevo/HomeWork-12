using HomeWork_12.Core.Classes.Student;
using HomeWork_12.Core.Classes.Ui_Tools;
using HomeWork_12.Core.Classes.University;
using HomeWork_12.Core.Enums.Adjust_Visibility_Options;
using HomeWork_12.Core.Enums.ObjectType;
using HomeWork_12.Utils.Validators.StudentValidator;
using HomeWork_12.Utils.Validators.UniversityValidator;

namespace HomeWork_11
{
    partial class MainWND
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private List<Student> _students = new List<Student>();
        private List<University> _universities = new List<University>();
        private ObjectType _currentObjType = ObjectType.None;

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

        private void SettingInputFields()
        {
            switch (_currentObjType)
            {
                case ObjectType.Student:
                    UiTools.SetFieldsVisibility(Visibility.Visible, new string[] { "surname" }, new Control[] { label_2 }, textBox_3, textBox_4, passwordBox, label_3, label_4, passwordLabel);
                    break;
                case ObjectType.University:
                    UiTools.SetFieldsVisibility(Visibility.Invisible, new string[] { "description" }, new Control[] { label_2 }, textBox_3, passwordBox, textBox_4, label_3, label_4, passwordLabel);
                    break;
            }
        }

        private void CreateObject()
        {
            switch (_currentObjType)
            {
                case ObjectType.Student:

                    if (StudentValidator.CheckStudentParams(textBox_0.Text, textBox_1.Text, textBox_2.Text, textBox_3.Text, passwordBox.Text, textBox_4.Text, _universities))
                    {
                        Student student = new(Int32.Parse(textBox_0.Text), textBox_1.Text, textBox_2.Text, textBox_3.Text, passwordBox.Text, textBox_4.Text);
                        _universities.Where(x => x.Name == student.UniversityName).First().AddStudent(student);
                        _students.Add(student);
                        UiTools.AddToList(objectBox, student);
                    }
                    else
                        MessageBox.Show("fill in the fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case ObjectType.University:

                    if (UniversityValidator.CheckUniversityParams(textBox_0.Text, textBox_1.Text, textBox_2.Text))
                    {
                        University university = new(Int32.Parse(textBox_0.Text), textBox_1.Text, textBox_2.Text);
                        //events for example
                        university.OnAdd += () => { MessageBox.Show("Student Added"); };
                        university.OnRemove += () => { MessageBox.Show("Student Removed"); };
                        _universities.Add(university);
                        UiTools.AddToList(objectBox, university);
                    }
                    else
                        MessageBox.Show("fill in the fields correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private bool CheckTheCorrectness()
        {
            bool result = true;
            switch (_currentObjType)
            {
                case ObjectType.Student:
                    result = UiTools.CheckFields("Fields are empty!", MessageBoxIcon.Error, textBox_0, textBox_1, textBox_2, textBox_3, passwordBox, textBox_4);
                    break;
                case ObjectType.University:
                    result = UiTools.CheckFields("Fields are empty!", MessageBoxIcon.Error, textBox_0, textBox_1, textBox_2);
                    break;
            }
            return result;
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWND));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            fileNameBox = new TextBox();
            readFile_btn = new Button();
            saveFilesBtn = new Button();
            label3 = new Label();
            objectBox = new ListBox();
            createBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            passwordLabel = new Label();
            passwordBox = new TextBox();
            label4 = new Label();
            label_4 = new Label();
            textBox_4 = new TextBox();
            label_3 = new Label();
            textBox_3 = new TextBox();
            label_2 = new Label();
            textBox_2 = new TextBox();
            label_1 = new Label();
            textBox_1 = new TextBox();
            label_0 = new Label();
            textBox_0 = new TextBox();
            objectTypeCombo = new ComboBox();
            tabPage2 = new TabPage();
            panel2 = new Panel();
            delBtn = new Button();
            label8 = new Label();
            label7 = new Label();
            studentNameForDelBox = new TextBox();
            label6 = new Label();
            univNameForDelBox = new TextBox();
            label9 = new Label();
            searchBtn = new Button();
            searchBox = new TextBox();
            rLabel = new Label();
            serachResult = new ListBox();
            tabPage4 = new TabPage();
            loginBtn = new Button();
            label11 = new Label();
            label10 = new Label();
            passLogBox = new TextBox();
            emailLogBox = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel2.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1318, 570);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BorderStyle = BorderStyle.FixedSingle;
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(fileNameBox);
            tabPage1.Controls.Add(readFile_btn);
            tabPage1.Controls.Add(saveFilesBtn);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(objectBox);
            tabPage1.Controls.Add(createBtn);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(objectTypeCombo);
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1302, 516);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Objects";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 245);
            label5.Name = "label5";
            label5.Size = new Size(99, 30);
            label5.TabIndex = 10;
            label5.Text = "file name";
            // 
            // fileNameBox
            // 
            fileNameBox.BorderStyle = BorderStyle.FixedSingle;
            fileNameBox.Location = new Point(16, 276);
            fileNameBox.Name = "fileNameBox";
            fileNameBox.Size = new Size(242, 39);
            fileNameBox.TabIndex = 9;
            // 
            // readFile_btn
            // 
            readFile_btn.Location = new Point(16, 385);
            readFile_btn.Name = "readFile_btn";
            readFile_btn.Size = new Size(242, 40);
            readFile_btn.TabIndex = 8;
            readFile_btn.Text = "Read From Files";
            readFile_btn.UseVisualStyleBackColor = true;
            readFile_btn.Click += readFileBtn_Click;
            // 
            // saveFilesBtn
            // 
            saveFilesBtn.Location = new Point(16, 339);
            saveFilesBtn.Name = "saveFilesBtn";
            saveFilesBtn.Size = new Size(242, 40);
            saveFilesBtn.TabIndex = 7;
            saveFilesBtn.Text = "Save to files";
            saveFilesBtn.UseVisualStyleBackColor = true;
            saveFilesBtn.Click += saveFilesBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(866, 6);
            label3.Name = "label3";
            label3.Size = new Size(94, 32);
            label3.TabIndex = 6;
            label3.Text = "Objects";
            // 
            // objectBox
            // 
            objectBox.FormattingEnabled = true;
            objectBox.Location = new Point(866, 41);
            objectBox.Name = "objectBox";
            objectBox.Size = new Size(410, 452);
            objectBox.TabIndex = 5;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(16, 456);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(242, 40);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(277, 6);
            label2.Name = "label2";
            label2.Size = new Size(211, 32);
            label2.TabIndex = 3;
            label2.Text = "Filling in the fields";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 6);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 2;
            label1.Text = "Object Type";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(passwordLabel);
            panel1.Controls.Add(passwordBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label_4);
            panel1.Controls.Add(textBox_4);
            panel1.Controls.Add(label_3);
            panel1.Controls.Add(textBox_3);
            panel1.Controls.Add(label_2);
            panel1.Controls.Add(textBox_2);
            panel1.Controls.Add(label_1);
            panel1.Controls.Add(textBox_1);
            panel1.Controls.Add(label_0);
            panel1.Controls.Add(textBox_0);
            panel1.Location = new Point(277, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 455);
            panel1.TabIndex = 1;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(296, 234);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(113, 32);
            passwordLabel.TabIndex = 19;
            passwordLabel.Text = "password";
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Location = new Point(296, 269);
            passwordBox.Name = "passwordBox";
            passwordBox.PasswordChar = '#';
            passwordBox.Size = new Size(248, 39);
            passwordBox.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Segoe UI", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 414);
            label4.Name = "label4";
            label4.Size = new Size(469, 25);
            label4.TabIndex = 17;
            label4.Text = "to create a student you first need to create a university";
            // 
            // label_4
            // 
            label_4.AutoSize = true;
            label_4.Location = new Point(22, 310);
            label_4.Name = "label_4";
            label_4.Size = new Size(184, 32);
            label_4.TabIndex = 16;
            label_4.Text = "university name";
            // 
            // textBox_4
            // 
            textBox_4.BorderStyle = BorderStyle.FixedSingle;
            textBox_4.Location = new Point(22, 345);
            textBox_4.Name = "textBox_4";
            textBox_4.Size = new Size(248, 39);
            textBox_4.TabIndex = 15;
            // 
            // label_3
            // 
            label_3.AutoSize = true;
            label_3.Location = new Point(22, 234);
            label_3.Name = "label_3";
            label_3.Size = new Size(72, 32);
            label_3.TabIndex = 14;
            label_3.Text = "email";
            // 
            // textBox_3
            // 
            textBox_3.BorderStyle = BorderStyle.FixedSingle;
            textBox_3.Location = new Point(22, 269);
            textBox_3.Name = "textBox_3";
            textBox_3.Size = new Size(248, 39);
            textBox_3.TabIndex = 13;
            // 
            // label_2
            // 
            label_2.AutoSize = true;
            label_2.Location = new Point(22, 159);
            label_2.Name = "label_2";
            label_2.Size = new Size(106, 32);
            label_2.TabIndex = 12;
            label_2.Text = "surname";
            // 
            // textBox_2
            // 
            textBox_2.BorderStyle = BorderStyle.FixedSingle;
            textBox_2.Location = new Point(22, 194);
            textBox_2.Name = "textBox_2";
            textBox_2.Size = new Size(248, 39);
            textBox_2.TabIndex = 11;
            // 
            // label_1
            // 
            label_1.AutoSize = true;
            label_1.Location = new Point(22, 83);
            label_1.Name = "label_1";
            label_1.Size = new Size(74, 32);
            label_1.TabIndex = 10;
            label_1.Text = "name";
            // 
            // textBox_1
            // 
            textBox_1.BorderStyle = BorderStyle.FixedSingle;
            textBox_1.Location = new Point(22, 118);
            textBox_1.Name = "textBox_1";
            textBox_1.Size = new Size(248, 39);
            textBox_1.TabIndex = 9;
            // 
            // label_0
            // 
            label_0.AutoSize = true;
            label_0.Location = new Point(22, 8);
            label_0.Name = "label_0";
            label_0.Size = new Size(34, 32);
            label_0.TabIndex = 8;
            label_0.Text = "id";
            // 
            // textBox_0
            // 
            textBox_0.BorderStyle = BorderStyle.FixedSingle;
            textBox_0.Location = new Point(22, 43);
            textBox_0.Name = "textBox_0";
            textBox_0.Size = new Size(248, 39);
            textBox_0.TabIndex = 7;
            // 
            // objectTypeCombo
            // 
            objectTypeCombo.FormattingEnabled = true;
            objectTypeCombo.Items.AddRange(new object[] { "University", "Student" });
            objectTypeCombo.Location = new Point(16, 41);
            objectTypeCombo.Name = "objectTypeCombo";
            objectTypeCombo.Size = new Size(242, 40);
            objectTypeCombo.TabIndex = 0;
            objectTypeCombo.SelectedIndexChanged += objectTypeCombo_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.BorderStyle = BorderStyle.FixedSingle;
            tabPage2.Controls.Add(panel2);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(searchBtn);
            tabPage2.Controls.Add(searchBox);
            tabPage2.Controls.Add(rLabel);
            tabPage2.Controls.Add(serachResult);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1302, 516);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Search";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(delBtn);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(studentNameForDelBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(univNameForDelBox);
            panel2.Location = new Point(18, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 303);
            panel2.TabIndex = 7;
            // 
            // delBtn
            // 
            delBtn.Location = new Point(26, 242);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(170, 43);
            delBtn.TabIndex = 14;
            delBtn.Text = "Delete";
            delBtn.UseVisualStyleBackColor = true;
            delBtn.Click += delBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(13, 134);
            label8.Name = "label8";
            label8.Size = new Size(108, 30);
            label8.TabIndex = 13;
            label8.Text = "Student Id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(13, 58);
            label7.Name = "label7";
            label7.Size = new Size(116, 30);
            label7.TabIndex = 12;
            label7.Text = "Univ Name";
            // 
            // studentNameForDelBox
            // 
            studentNameForDelBox.Location = new Point(13, 167);
            studentNameForDelBox.Name = "studentNameForDelBox";
            studentNameForDelBox.Size = new Size(203, 39);
            studentNameForDelBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 12);
            label6.Name = "label6";
            label6.Size = new Size(174, 32);
            label6.TabIndex = 10;
            label6.Text = "Delete Student";
            // 
            // univNameForDelBox
            // 
            univNameForDelBox.Location = new Point(13, 90);
            univNameForDelBox.Name = "univNameForDelBox";
            univNameForDelBox.Size = new Size(203, 39);
            univNameForDelBox.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(18, 6);
            label9.Name = "label9";
            label9.Size = new Size(190, 32);
            label9.TabIndex = 6;
            label9.Text = "University Name";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(16, 456);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(242, 40);
            searchBtn.TabIndex = 5;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchBox
            // 
            searchBox.BorderStyle = BorderStyle.FixedSingle;
            searchBox.Location = new Point(18, 41);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(235, 39);
            searchBox.TabIndex = 2;
            // 
            // rLabel
            // 
            rLabel.AutoSize = true;
            rLabel.Location = new Point(277, 6);
            rLabel.Name = "rLabel";
            rLabel.Size = new Size(78, 32);
            rLabel.TabIndex = 1;
            rLabel.Text = "Result";
            // 
            // serachResult
            // 
            serachResult.FormattingEnabled = true;
            serachResult.Location = new Point(277, 41);
            serachResult.Name = "serachResult";
            serachResult.Size = new Size(992, 452);
            serachResult.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(loginBtn);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(passLogBox);
            tabPage4.Controls.Add(emailLogBox);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1302, 516);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Login";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(436, 314);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(372, 46);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(436, 192);
            label11.Name = "label11";
            label11.Size = new Size(111, 32);
            label11.TabIndex = 3;
            label11.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(436, 89);
            label10.Name = "label10";
            label10.Size = new Size(71, 32);
            label10.TabIndex = 2;
            label10.Text = "Email";
            // 
            // passLogBox
            // 
            passLogBox.Location = new Point(436, 227);
            passLogBox.Name = "passLogBox";
            passLogBox.Size = new Size(372, 39);
            passLogBox.TabIndex = 1;
            // 
            // emailLogBox
            // 
            emailLogBox.Location = new Point(436, 124);
            emailLogBox.Name = "emailLogBox";
            emailLogBox.Size = new Size(372, 39);
            emailLogBox.TabIndex = 0;
            // 
            // MainWND
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1315, 571);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWND";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home Work 12";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private ComboBox objectTypeCombo;
        private Label label2;
        private Label label1;
        private Button createBtn;
        private ListBox objectBox;
        private Label label3;
        private Label label_0;
        private TextBox textBox_0;
        private Label label_2;
        private TextBox textBox_2;
        private Label label_1;
        private TextBox textBox_1;
        private Label label_4;
        private TextBox textBox_4;
        private Label label_3;
        private TextBox textBox_3;
        private ListBox serachResult;
        private TextBox searchBox;
        private Label rLabel;
        private Label label9;
        private Button searchBtn;
        private Label label4;
        private Label passwordLabel;
        private TextBox passwordBox;
        private TabPage tabPage4;
        private Button readFile_btn;
        private Button saveFilesBtn;
        private Label label5;
        private TextBox fileNameBox;
        private Panel panel2;
        private Button delBtn;
        private Label label8;
        private Label label7;
        private TextBox studentNameForDelBox;
        private Label label6;
        private TextBox univNameForDelBox;
        private Button loginBtn;
        private Label label11;
        private Label label10;
        private TextBox passLogBox;
        private TextBox emailLogBox;
    }
}
