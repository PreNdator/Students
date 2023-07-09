using System;
using System.IO;
using System.Windows.Forms;

namespace Students
{

    public partial class Form1 : Form
    {
        private const string path = "Info\\";
        private FileStream file;
        private StreamWriter writer;
        private string fullFileName;
        private bool isFileEmpty = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (!string.IsNullOrEmpty(filename.Text))
            {
                fullFileName = path + filename.Text + ".txt";
                if (File.Exists(fullFileName))
                {

                    file = new FileStream(fullFileName, FileMode.Open);
                    StreamReader sr = new StreamReader(file);
                    string line;
                    if (!sr.EndOfStream)
                    {
                        isFileEmpty = false;
                    }
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        studentsFile.Text += line + "\r\n";
                    }
                    sr.Close();
                }

                file = new FileStream(fullFileName, FileMode.Append);
                showFields();
                writer = new StreamWriter(file);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите имя файла.");
            }
        }

        private void showFields()
        {
            open.Visible = false;
            filename.ReadOnly = true;

            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            grade1.Visible = true;
            grade2.Visible = true;
            grade3.Visible = true;
            grade4.Visible = true;
            grade5.Visible = true;

            first_name.Visible = true;
            last_name.Visible = true;
            closeButton.Visible = true;
            addButton.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox_OnlyGrades(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if ((number < 50 || number > 53) && number != 8)
            {
                e.Handled = true;
                MessageBox.Show("Пожалуйста, введите цифру от 2 до 5.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void clearFields()
        {
            grade1.Text = "";
            grade2.Text = "";
            grade3.Text = "";
            grade4.Text = "";
            grade5.Text = "";

            first_name.Text = "";
            last_name.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if
            (
            !string.IsNullOrEmpty(first_name.Text) &&
            !string.IsNullOrEmpty(last_name.Text) &&
            !string.IsNullOrEmpty(grade1.Text) &&
            !string.IsNullOrEmpty(grade2.Text) &&
            !string.IsNullOrEmpty(grade3.Text) &&
            !string.IsNullOrEmpty(grade4.Text) &&
            !string.IsNullOrEmpty(grade5.Text)
            )
            {
                string studentInfo = first_name.Text + ' ' + last_name.Text + ' '
                    + grade1.Text + ' ' + grade2.Text + ' ' + grade3.Text + ' ' + grade4.Text + ' ' + grade5.Text + '\n';
                studentsFile.Text += studentInfo + "\r\n";
                writer.Write(studentInfo);
                isFileEmpty = false;

                clearFields();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (!isFileEmpty)
            {
                writer.Close();
                file.Close();

                Form2 form2 = new Form2();
                form2.Show();

                form2.setFile(new FileStream(fullFileName, FileMode.Open));

                this.Hide();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите как минимум одного студента");
            }
        }
    }
}
