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
    public partial class TreeForm : Form
    {
        public void FillForm(TreeBase<string> tree)
        {
            TreeBase<string>.Node curr = tree.root;
            rootText.Text = curr.info+' '+curr.key.ToString();

            if (curr.left != null)
            {
                layer2Text1.Text = curr.left.info + ' ' + curr.left.key.ToString();
                if(curr.left.left!=null)
                    layer3Text1.Text = curr.left.left.info + ' ' + curr.left.left.key.ToString();
                if(curr.left.right != null)
                    layer3Text2.Text = curr.left.right.info + ' ' + curr.left.right.key.ToString();

            }
            if (curr.right != null)
            {
                layer2Text2.Text = curr.right.info + ' ' + curr.right.key.ToString();
                if (curr.right.left != null)
                    layer3Text3.Text = curr.left.right.info + ' ' + curr.left.right.key.ToString();
                if (curr.right.right != null)
                    layer3Text4.Text = curr.right.right.info + ' ' + curr.right.right.key.ToString();
            }

        }
        public TreeForm()
        {
            InitializeComponent();
        }
    }
}
