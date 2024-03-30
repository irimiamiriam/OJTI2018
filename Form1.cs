using OJTI2018.DataBase;
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

namespace OJTI2018
{
    public partial class eLearning2018_start : Form
    {
     
      List<Bitmap> images = new List<Bitmap>();
        public eLearning2018_start()
        {
            InitializeComponent();
            images = GetAllImages();

            progressBar1.Value = 0;
            progressBar1.Maximum = images.Count()-1;
            pictureBox1.Image = images.First();
        }

        private List<Bitmap> GetAllImages()
        {
            List<Bitmap> img = new List<Bitmap>();
            string imgFolderPath = "Imagini";
           
            string workingDirectory = Environment.CurrentDirectory;
            string projectBinDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            var result = Path.Combine(projectBinDirectory, imgFolderPath); 
            string[] fileNamesFromFolder= Directory.GetFiles(result);
            foreach (string fileName in fileNamesFromFolder) 
            {
                Bitmap bitmap = new Bitmap(fileName);
                img.Add(bitmap);
            }
            return img;
        }

        private void eLearning2018_start_Load(object sender, EventArgs e)
        {
            DatabaseHelper.Delete();
            DatabaseHelper.Initialisation();
         
            ShowManual();
        }

        private void ShowManual()
        { 
            Prevbutton.Enabled = false;
            Nextbutton.Enabled = false;
          
            timerImg.Start();

        }
     

        private void timerImg_Tick(object sender, EventArgs e)
        { 

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                pictureBox1.Image = images[progressBar1.Value];
            }
            else { timerImg.Stop(); timerImg.Start(); }
        }

        private void Autobutton_Click(object sender, EventArgs e)
        {
            if (Autobutton.Text == "Manual")
            {
                timerImg.Stop();
                Autobutton.Text = "Auto";
                Prevbutton.Enabled = true;
                Nextbutton.Enabled = true;


            }else
            {
                Autobutton.Text = "Manual";
                ShowManual();
            }
        }

        private void Prevbutton_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0 )
            {
                progressBar1.Value -= 1;
                pictureBox1.Image= images[progressBar1.Value];
            }
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                pictureBox1.Image = images[progressBar1.Value];

            }
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            int idElevInregistrat = DatabaseHelper.SearchUser(emailtextBox.Text, passtextBox.Text);
       
            if (idElevInregistrat != 0)
            {
                eLearning2018_Elev f1 = new eLearning2018_Elev(idElevInregistrat);
                this.Hide();
                f1.ShowDialog();
                this.Show();
            }
            else { MessageBox.Show("Eroare autentificare");
                emailtextBox.Text = "";
                passtextBox.Text = "";
            }
        }
    }
   
}
