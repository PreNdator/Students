using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    struct Student{
        public string first_name { get; }
        public string last_name { get; }
        public int[] grades { get; }
        public Student(string first_name, string last_name, int[] grades)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.grades = new int[grades.Length];
            for(int i=0; i<grades.Length; ++i)
            {
                this.grades[i] = grades[i];
            }
        }
    }

    public partial class Form2 : Form
    {

        const int gradesLength = 5;
        const int bestStudentsCount = 3;

        private MyList<Tuple<string, float>> studentsList1;
        private MyList<Tuple<string, float>> studentsList2;
        private SearchTree<string> studentTree;
        private AVLTree<string> studentAVLTree;
        private MyList<Student> topStudents;

        private Form currForm = null;

        MyList<Student> studentList;
        public Form2()
        {
            InitializeComponent();
        } 
        
        public void setFile(FileStream file)
        {
            readFile(file);
            studentsList1 = Tasks.fillList1(studentList);
            studentsList2 = Tasks.fillList2(studentList);
            topStudents = Tasks.TopStudents(studentList, bestStudentsCount);
            studentTree = Tasks.FillSearchTree(studentList);
            studentAVLTree = Tasks.FillAVLTree(studentList);
            setBestStudents();
        }

        private void setBestStudents()
        {
            if (topStudents.first == null) {
                bestStudents.Text = "Студенты с 4 и 5 отсутствуют";
            }
            else
            {
                MyList<Student>.Node curr = topStudents.first;
                while(curr != null)
                {
                    int[] grades = curr.info.grades;
                    bestStudents.Text += curr.info.last_name;
                    for(int i=0; i<grades.Length; i++)
                    {
                        bestStudents.Text += ' ' + grades[i].ToString();
                    }
                    bestStudents.Text += "\r\n";
                    curr = curr.next;
                }
            }
        }

        private void readFile(FileStream file)
        {
            StreamReader sr = new StreamReader(file);

            string line;
            int[] grades = new int[gradesLength];
            studentList = new MyList<Student>();
       
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                string[] info = line.Split(' ');
                
                for(int i=0; i<gradesLength; ++i)
                {
                    grades[i] = int.Parse(info[i + 2]);
                }
                studentList.Add(new Student(info[0], info[1], grades));
            }

            sr.Close();
            file.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currForm != null)
            {
                currForm.Close();
            }
            ListForm lf = new ListForm();
            lf.FillForm(studentsList1);

            currForm = lf;
            currForm.TopLevel = false;
            Controls.Add(currForm);
            currForm.Show();
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (currForm != null)
            {
                currForm.Close();
            }
            ListForm lf = new ListForm();
            lf.FillForm(studentsList2);
            currForm = lf;
            currForm.TopLevel = false;
            Controls.Add(currForm);
            currForm.Show();
        }

        private void TreeButton_Click(object sender, EventArgs e)
        {
            if (currForm != null)
            {
                currForm.Close();
            }
            TreeForm tf = new TreeForm();
            tf.FillForm(studentTree);
            currForm = tf;
            currForm.TopLevel = false;
            Controls.Add(currForm);
            currForm.Show();
        }

        private void AVLTreeButton_Click(object sender, EventArgs e)
        {
            if (currForm != null)
            {
                currForm.Close();
            }
            TreeForm tf = new TreeForm();
            tf.FillForm(studentAVLTree);
            currForm = tf;
            currForm.TopLevel = false;
            Controls.Add(currForm);
            currForm.Show();
        }
    }
}
