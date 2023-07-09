using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    internal static class Tasks
    {
        private static float mean(int[] nums)
        {
            float sum = 0;
            for (int i = 0; i < nums.Length; ++i)
            {
                sum += nums[i];
            }
            return sum / nums.Length;
        }
        private static bool isOnly3(int[] nums)
        {
            bool result = true;
            for (int i = 0; i < nums.Length; ++i)
            {
                if (nums[i] != 3)
                    result = false;
            }
            return result;
        }
        //Пункт 2
        public static MyList<Tuple<string, float>> fillList1(MyList<Student> studentList)
        {
            MyList<Tuple<string, float>>  studentsList1 = new MyList<Tuple<string, float>>();

            Tuple<string, float> student;
            MyList<Student>.Node curr = studentList.first;

            while (curr != null && !isOnly3(curr.info.grades) )
            {
                student = new Tuple<string, float>(curr.info.first_name, mean(curr.info.grades));
                studentsList1.Add(student);
                curr = curr.next;
            }
            MyList<Tuple<string, float>>.Node lastOnly3 = null;
            if (curr != null && isOnly3(curr.info.grades))
            {
                student = new Tuple<string, float>(curr.info.first_name, mean(curr.info.grades));
                studentsList1.AddBefore(studentsList1.first, student);
                lastOnly3 = studentsList1.first;
                curr = curr.next;
            }
            while (curr != null)
            {
                student = new Tuple<string, float>(curr.info.last_name, mean(curr.info.grades));
                if (isOnly3(curr.info.grades))
                {
                    studentsList1.AddAfter(lastOnly3, student);
                    lastOnly3 = lastOnly3.next;
                }
                else
                {
                    studentsList1.Add(student);
                }
                curr = curr.next;
            }
            return studentsList1;
        }
        //Пункт 3
        public static MyList<Tuple<string, float>> fillList2(MyList<Student> studentList)
        {
            MyList<Tuple<string, float>> studentsList2 = new MyList<Tuple<string, float>>();

            Tuple<string, float> student;
            MyList<Student>.Node curr = studentList.first;
            MyList<Tuple<string, float>>.Node curr2 = null;
            while (curr != null)
            {
                float currMean = mean(curr.info.grades);
                student = new Tuple<string, float>(curr.info.last_name, currMean);
                
                curr2 = studentsList2.first;
                
                while (curr2 != null && curr2.info.Item2 < currMean)
                {
                    curr2 = curr2.next;
                }
                if (curr2 == null)
                {
                    studentsList2.Add(student);
                }
                else
                {
                    studentsList2.AddBefore(curr2, student);
                }
                curr = curr.next;
            }
            return studentsList2;
        }
        public static SearchTree<string> FillSearchTree(MyList<Student> studentList)
        {
            SearchTree<string> tree = new SearchTree<string>();
            MyList<Student>.Node curr = studentList.first;

            while (curr != null)
            {
                tree.Add(curr.info.last_name, mean(curr.info.grades));
                curr = curr.next;
            }
            return tree;

        }
        public static AVLTree<string> FillAVLTree(MyList<Student> studentList)
        {
            AVLTree<string> tree = new AVLTree<string>();
            MyList<Student>.Node curr = studentList.first;

            while (curr != null)
            {
                tree.Add(curr.info.last_name, mean(curr.info.grades));
                curr = curr.next;
            }
            return tree;

        }

        private static int count4and5(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 4 || nums[i] == 5)
                {
                    result++;
                }
            }
            return result;
        }
        private static void selectMax(Tuple<Student, int>[] students, int count)
        {
            int max = 0;
            int size = students.Length;
            Tuple<Student, int> temp;
            for (int i=0; i<count; ++i)
            {
                max = i;
                for (int j = i+1; j < size; ++j)
                {
                    if (students[max].Item2 < students[j].Item2)
                    {
                        max = j;
                    }
                }
                temp = students[i];
                students[i] = students[max];
                students[max] = temp;
            }

        }

        public static MyList<Student> TopStudents(MyList<Student> studentList, int bestStudentsCount)
        {
            int count = studentList.count;
            Tuple<Student,int>[] studentVec = new Tuple<Student, int>[count];
            MyList<Student>.Node curr = studentList.first;
            
            
            for (int i=0; i< count; ++i)
            {
                studentVec[i] = new Tuple<Student, int>(curr.info, count4and5(curr.info.grades));
                curr = curr.next;
            }
            bestStudentsCount = Math.Min(studentVec.Length, bestStudentsCount);
            selectMax(studentVec, bestStudentsCount);

            MyList<Student> students = new MyList<Student>();
            for (int i = 0; i < bestStudentsCount; ++i)
            {
                if (studentVec[i].Item2 > 0)
                {
                    students.Add(studentVec[i].Item1);
                }
            }
            return students;
        }

    }
}
