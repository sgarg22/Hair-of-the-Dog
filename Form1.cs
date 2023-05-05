using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3B
{

    /// <summary>
    /// 
    /// @author : SHARANSH GARG
    /// </summary>


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(listBox1.SelectedIndex>=0 && comboBox1.SelectedIndex >= 0)
            {
                serviceButton.Enabled = true;
            }

        }
        int[] servicePrice = { 30,20,40,50,200,60};

        int[] namePrice = { 30,45,40,50,55};

        public string setHairDresser()
        {
            string name="";

            if (comboBox1.SelectedIndex == 0)
            {
                name = "Jane";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                name = "Pat";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                name = "Ron";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                name = "Sue";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                name = "Laurie";
            }
            return name;

        }

        public string getService()
        {
            string service = "";

            if (listBox1.SelectedIndex == 0)
            {service = "Cut";}

            if (listBox1.SelectedIndex == 1)
            {service = "Wash, blow-dry, and style";}

            if (listBox1.SelectedIndex == 2)
            { service = "Colour "; }

            if (listBox1.SelectedIndex == 3)
            {
                service = "Highlights";
            }

            if (listBox1.SelectedIndex == 4)
            {
                service = "Extension";
            }

            if (listBox1.SelectedIndex == 5)
            {
                service = "Up-do";
            }
            return service;
        }








        private void button3_Click(object sender, EventArgs e)
        {
            total = 0;
            comboBox1.Enabled = true;
            serviceButton.Enabled = false;
            listBox3.Items.Clear();
            calButton.Enabled = false;
            textBox1.Text = "";
            listBox2.Items.Clear();
            list1.Clear();List2.Clear();

        }

        List<string> list1 = new List<string>();
        List<string> List2 = new List<string>();

        int total = 0;

        private void serviceButton_Click(object sender, EventArgs e)
        {


           // label1.Text = getService();
            if (comboBox1.Enabled == true)
            {
                list1.Add(setHairDresser());
                List2.Add(namePrice[comboBox1.SelectedIndex].ToString());
            }
            
            if (!list1.Contains(getService()))
            {
                list1.Add(getService());
                List2.Add(servicePrice[listBox1.SelectedIndex].ToString());
            }
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            foreach(String s in list1)
            {
                listBox2.Items.Add(s);
            }
            total = 0;
            foreach(string s in List2)
            {
                listBox3.Items.Add(s);
                total += int.Parse(s);
            }
            calButton.Enabled = true;
            comboBox1.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && comboBox1.SelectedIndex >= 0)
            {
                serviceButton.Enabled = true;
            }

        }

        private void calButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = total.ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
