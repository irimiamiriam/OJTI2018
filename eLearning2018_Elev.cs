using OJTI2018.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace OJTI2018
{
    public partial class eLearning2018_Elev : Form
    {
        DataTable randomItems = new DataTable();
        int indItem = 0;

        public eLearning2018_Elev()
        {
            InitializeComponent();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            indItem = 0;
            randomItems = DatabaseHelper.RandomItems();
            DataRow row = randomItems.Rows[0];
            itemEnuntTextBox.Text = row[1].ToString();
            itemLabel.Text = "Item nr." + (indItem+1);
            if (row[0].ToString() == "1")
            {
                Label enunt1 = new Label();
                enunt1.Text = "Rapsuns:";
                TextBox raspuns = new TextBox();
                enunt1.Location = new Point(10, 10);
                raspuns.Location = new Point(40, 10);
                raspuns.Size = new Size(300, 30);
                panel1.Controls.Add(enunt1);
                panel1.Controls.Add(raspuns);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            indItem++;
            if (indItem < randomItems.Rows.Count)
            {   panel1.Controls.Clear();
                DataRow row = randomItems.Rows[indItem];
                itemEnuntTextBox.Text = row[1].ToString();
                itemLabel.Text = "Item nr."+ (indItem+1);
                if (row[0].ToString() == "1")
                { 
                    Label enunt1 = new Label();
                    enunt1.Text = "Rapsuns:";
                    TextBox raspuns = new TextBox();
                    enunt1.Location = new Point(10 , 10);
                    raspuns.Location= new Point(40 , 10);
                    panel1.Controls.Add(enunt1);
                    panel1.Controls.Add(raspuns);
                   
                }
                if (row[0].ToString()== "2")
                {
                    
                    RadioButton radioButton1 = new RadioButton();
                    radioButton1.Text = row[2].ToString();
                    RadioButton radioButton2 = new RadioButton();
                    radioButton2.Text = row[3].ToString();
                    RadioButton radioButton3 = new RadioButton();
                    radioButton3.Text = row[4].ToString();
                    RadioButton radioButton4 = new RadioButton();
                    radioButton4.Text = row[5].ToString();
                    radioButton1.Location = new Point(10, 10);
                    radioButton2.Location = new Point(10, 30);
                    radioButton3.Location = new Point(10, 50);
                    radioButton4.Location = new Point(10, 70);
                    panel1.Controls.Add(radioButton1);
                    panel1.Controls.Add(radioButton2);
                    panel1.Controls.Add(radioButton3);
                    panel1.Controls.Add(radioButton4);
                   
                   
                }
                if (row[0].ToString() == "3") 
                {
                    CheckBox CheckBox1 = new CheckBox();
                    CheckBox1.Text = row[2].ToString();
                    CheckBox CheckBox2 = new CheckBox();
                    CheckBox2.Text = row[3].ToString();
                    CheckBox CheckBox3 = new CheckBox();
                    CheckBox3.Text = row[4].ToString();
                    CheckBox CheckBox4 = new CheckBox();
                    CheckBox4.Text = row[5].ToString();
                    CheckBox1.Location = new Point(10, 10);
                    CheckBox2.Location = new Point(10, 30);
                    CheckBox3.Location = new Point(10, 50);
                    CheckBox4.Location = new Point(10, 70);
                    panel1.Controls.Add(CheckBox1);
                    panel1.Controls.Add(CheckBox2);
                    panel1.Controls.Add(CheckBox3);
                    panel1.Controls.Add(CheckBox4);
                }
                if (row[0].ToString() == "4")
                {
                    RadioButton radioAdevarat = new RadioButton();
                    radioAdevarat.Text = "adevarat";
                    RadioButton radioFals = new RadioButton();
                    radioFals.Text = "fals";
                    radioAdevarat.Location = new Point(10, 10);
                    radioFals.Location = new Point(10, 30);
                    panel1.Controls.Add(radioAdevarat);
                    panel1.Controls.Add(radioFals);

                }
              
            }
        }

       
    }
}
