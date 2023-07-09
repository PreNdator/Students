using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students
{
    public partial class ListForm : Form
    {
        TextBox curr;

        public void FillForm(MyList<Tuple<string, float>> list)
        {
            curr.Text = list.first.info.Item1 + ' ' + list.first.info.Item2.ToString();
            MyList<Tuple<string, float>>.Node currNode = list.first.next;
            while (currNode != null)
            {
                TextBox newCurr = new TextBox();
                newCurr.Location = new Point(curr.Location.X, curr.Location.Y + curr.Height * 2);
                newCurr.Size = curr.Size;
                newCurr.ReadOnly = true;
                newCurr.Text = currNode.info.Item1 + ' ' + currNode.info.Item2.ToString();
                this.Controls.Add(newCurr);


                currNode = currNode.next;
                curr = newCurr;
            }
            this.Refresh();


        }

        public ListForm()
        {
            InitializeComponent();
            curr = textBox1;
        }
    }
}
