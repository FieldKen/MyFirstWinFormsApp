using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormsApp
{
    public partial class Form1 : Form
    {
        List<string> namen = new List<string>();

        public Form1()
        {
            InitializeComponent();
            namen.Add("Mohamed");
            namen.Add("Claire");
            namen.Add("Ken");
            namen.Add("Nick");

            foreach (var item in namen)
            {
                cbItems.Items.Add(item);
            }
        }

        private void btnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtInput.Size.Width.ToString());
        }

        private void btnButton_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Blijft van mij af!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbList.Items.Add("Vincent");
            lbList.Items.Add("Gawein");
            lbList.Items.Add("Arno");
            lbList.Items.Add("Katia");

            /*cbItems.Items.Add("Vincent");
            cbItems.Items.Add("Gawein");
            cbItems.Items.Add("Arno");
            cbItems.Items.Add("Katia");*/

            clbMijnLijst.Items.Add("Vincent");
            clbMijnLijst.Items.Add("Gawein");
            clbMijnLijst.Items.Add("Arno");
            clbMijnLijst.Items.Add("Katia");
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            lblLabel.Text = ((TextBox)sender).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbCheckbox.Checked)
                MessageBox.Show("Is aangevinkt");
            else
                MessageBox.Show("Is afgevinkt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbButton.Checked)
                MessageBox.Show("Is aangevinkt");
            else
                MessageBox.Show("Is afgevinkt");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pbBar.Value += 10;
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lbList.SelectedItem.ToString());
            MessageBox.Show(lbList.SelectedIndex.ToString());
        }

        private void clbMijnLijst_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtClb.Text = string.Empty;
            txtClbAll.Text = string.Empty;

            foreach (var item in clbMijnLijst.CheckedItems)
            {
                txtClb.Text += item + " ";
            }

            foreach (var item in clbMijnLijst.Items)
            {
                txtClbAll.Text += item + " ";
            }
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbItems.SelectedItem.ToString());
        }
    }
}
