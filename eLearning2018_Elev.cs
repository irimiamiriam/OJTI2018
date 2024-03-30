using OJTI2018.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace OJTI2018
{
    public partial class eLearning2018_Elev : Form
    {
        DataTable randomItems = new DataTable();
        int indItem = 0;
        int punctaj = 1;
        int idElev;
        int currentPoint = 0;
        int currentPointMedie = 0;

        public eLearning2018_Elev(int id)
        {
            InitializeComponent();
            idElev = id;
            string nume = DatabaseHelper.GetNumePrenume(idElev);
            dataGridViewNote.DataSource = DatabaseHelper.NoteElev(idElev);
            
            numeElevLabel.Text = "Carnetul de note al elevului: " + nume;
           
            ChartGenerating();
            

        }

        private void ChartGenerating()
        {
         
            
            chart1.Dock = DockStyle.Fill;
            ChartArea area = new ChartArea();
            chart1.ChartAreas.Add(area);
            Series seriesNote = new Series("Note elev");
            Series seriesMedie = new Series("Media elevilor din clasa");
            seriesMedie.ChartType = SeriesChartType.Line;
            seriesNote.ChartType = SeriesChartType.Line;
            double medie = DatabaseHelper.GetMedie();
            
            foreach (DataGridViewRow row in dataGridViewNote.Rows)
            {

                if (row.IsNewRow) { break; }
                int nota = Convert.ToInt32(row.Cells["Nota"].Value);
                seriesNote.Points.AddXY(currentPoint, nota);
                currentPoint++;
            }
            seriesMedie.Points.AddXY(currentPointMedie, medie);

            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.Series.Add(seriesNote);
            chart1.Series.Add(seriesMedie);
            
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            indItem = 0;
            punctaj = 1;
            raspundeButton.Enabled = true;
            nextButton.Enabled = true;
            randomItems = DatabaseHelper.RandomItems();
            DataRow row = randomItems.Rows[0];
            itemEnuntTextBox.Text = row[1].ToString();
            punctajLabel.Text = "Punctaj:" + punctaj;
            itemLabel.Text = "Item nr." + (indItem+1);
            if (row[0].ToString() == "1")
            {
                Label enunt1 = new Label();
                enunt1.Text = "Rapsuns:";
                TextBox raspuns = new TextBox();
                enunt1.Location = new Point(10, 10);
                raspuns.Location = new Point(enunt1.Right + 5, 10);
                raspuns.Size = new Size(300, 30);
                
                panel1.Controls.Add(enunt1);
                panel1.Controls.Add(raspuns);
                
                raspuns.Focus();
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
                    raspuns.Location = new Point(enunt1.Right + 5, 10);
                    raspuns.Size = new Size(300, 30);

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
                if (indItem == 8)
                {
                    nextButton.Enabled = false;
                }

              
            }
        }

        private void testeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void carnetDeNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        private void graficNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        private void raspundeButton_Click(object sender, EventArgs e)
        {
            DataRow row = randomItems.Rows[indItem];
            if (row[0].ToString() == "1")
            {
                string text= "";
                foreach (Control control in panel1.Controls)
                {
                    if (control is TextBox)
                    { text = control.Text; }
                }
                text = text.Replace(" ", "");
                string raspuns = row[6].ToString().Replace(" ", "");

                if (string.Equals(text, raspuns ,StringComparison.OrdinalIgnoreCase))
                {
                    punctaj++;
                    punctajLabel.Text = "Punctaj:" + punctaj;

                }
              

            }
            if (row[0].ToString() == "2")
            {
                int id = 0;
                foreach(Control control in panel1.Controls)
                {
                    if(control is RadioButton)
                    { id++;
                        RadioButton rb = control as RadioButton;
                        if (rb.Checked)
                        {
                            if( id == Convert.ToInt32(row[6])) 
                            {
                                punctaj++;
                                punctajLabel.Text = "Punctaj:" + punctaj;
                            }
                        }
                    }
                }

                
            }
            if (row[0].ToString() == "3")
            {
                string ras = "";
                int id = 0;
                foreach (Control control in panel1.Controls)
                {
                    if (control is CheckBox)
                    {   id++;
                        CheckBox cb = control as CheckBox;
                        if (cb.Checked)
                        {
                            ras += id;
                        }
                    }
                }
                if(ras== row[6].ToString())
                {
                    punctaj++;
                    punctajLabel.Text = "Punctaj:" + punctaj;
                }
                
            }
            if (row[0].ToString() == "4")
            {
                foreach (Control control in panel1.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton rb = control as RadioButton;
                        if (rb.Checked)
                        {
                            if ((rb.Text == "adevarat" && row[6].ToString()=="1")|| (rb.Text == "fals" && row[6].ToString() == "0"))
                            {
                                punctaj++;
                                punctajLabel.Text = "Punctaj:" + punctaj;
                            }
                        }
                    }
                }
               
            }
            if (indItem == 8)
            {
                DatabaseHelper.InsertIntoEvaluari(idElev, punctaj);
                DatabaseHelper.NoteElev(idElev);
                dataGridViewNote.DataSource = DatabaseHelper.NoteElev(idElev);
                raspundeButton.Enabled = false;
                double medie = DatabaseHelper.GetMedie();
                chart1.Series["Note elev"].Points.AddXY(++currentPoint, punctaj);
                chart1.Series["Media elevilor din clasa"].Points.AddXY(++currentPointMedie, medie);
            }

        }

        private void printButton_Click(object sender, EventArgs e)
        {
           PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.Document= printDocument;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap document = new Bitmap(dataGridViewNote.Width,dataGridViewNote.Height);
            dataGridViewNote.DrawToBitmap(document, new Rectangle(0, 0 ,document.Width, document.Height));
            e.Graphics.DrawImage(document, 0,0);

        }
    }
}
