namespace OJTI2018
{
    partial class eLearning2018_Elev
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eLearning2018_Elev));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.elevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carnetDeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.testeTabPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.raspundeButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.punctajLabel = new System.Windows.Forms.Label();
            this.itemEnuntTextBox = new System.Windows.Forms.TextBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.carnetTabPage = new System.Windows.Forms.TabPage();
            this.numeElevLabel = new System.Windows.Forms.Label();
            this.printButton = new System.Windows.Forms.Button();
            this.dataGridViewNote = new System.Windows.Forms.DataGridView();
            this.graficTabPage = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.testeTabPage.SuspendLayout();
            this.carnetTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNote)).BeginInit();
            this.graficTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.elevToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1255, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // elevToolStripMenuItem
            // 
            this.elevToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testeToolStripMenuItem,
            this.carnetDeNoteToolStripMenuItem,
            this.graficNoteToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.elevToolStripMenuItem.Name = "elevToolStripMenuItem";
            this.elevToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.elevToolStripMenuItem.Text = "Elev";
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(307, 44);
            this.testeToolStripMenuItem.Text = "Teste";
            this.testeToolStripMenuItem.Click += new System.EventHandler(this.testeToolStripMenuItem_Click);
            // 
            // carnetDeNoteToolStripMenuItem
            // 
            this.carnetDeNoteToolStripMenuItem.Name = "carnetDeNoteToolStripMenuItem";
            this.carnetDeNoteToolStripMenuItem.Size = new System.Drawing.Size(307, 44);
            this.carnetDeNoteToolStripMenuItem.Text = "Carnet de note";
            this.carnetDeNoteToolStripMenuItem.Click += new System.EventHandler(this.carnetDeNoteToolStripMenuItem_Click);
            // 
            // graficNoteToolStripMenuItem
            // 
            this.graficNoteToolStripMenuItem.Name = "graficNoteToolStripMenuItem";
            this.graficNoteToolStripMenuItem.Size = new System.Drawing.Size(307, 44);
            this.graficNoteToolStripMenuItem.Text = "Grafic note";
            this.graficNoteToolStripMenuItem.Click += new System.EventHandler(this.graficNoteToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(307, 44);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.testeTabPage);
            this.tabControl1.Controls.Add(this.carnetTabPage);
            this.tabControl1.Controls.Add(this.graficTabPage);
            this.tabControl1.Location = new System.Drawing.Point(28, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1215, 608);
            this.tabControl1.TabIndex = 1;
            // 
            // testeTabPage
            // 
            this.testeTabPage.Controls.Add(this.panel1);
            this.testeTabPage.Controls.Add(this.raspundeButton);
            this.testeTabPage.Controls.Add(this.nextButton);
            this.testeTabPage.Controls.Add(this.punctajLabel);
            this.testeTabPage.Controls.Add(this.itemEnuntTextBox);
            this.testeTabPage.Controls.Add(this.itemLabel);
            this.testeTabPage.Controls.Add(this.startButton);
            this.testeTabPage.Location = new System.Drawing.Point(8, 39);
            this.testeTabPage.Name = "testeTabPage";
            this.testeTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.testeTabPage.Size = new System.Drawing.Size(1199, 561);
            this.testeTabPage.TabIndex = 0;
            this.testeTabPage.Text = "Teste";
            this.testeTabPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(179, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 311);
            this.panel1.TabIndex = 6;
            // 
            // raspundeButton
            // 
            this.raspundeButton.Location = new System.Drawing.Point(1014, 487);
            this.raspundeButton.Name = "raspundeButton";
            this.raspundeButton.Size = new System.Drawing.Size(157, 57);
            this.raspundeButton.TabIndex = 5;
            this.raspundeButton.Text = "Raspunde";
            this.raspundeButton.UseVisualStyleBackColor = true;
            this.raspundeButton.Click += new System.EventHandler(this.raspundeButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(821, 487);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(157, 57);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Urmatorul";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // punctajLabel
            // 
            this.punctajLabel.AutoSize = true;
            this.punctajLabel.Location = new System.Drawing.Point(186, 51);
            this.punctajLabel.Name = "punctajLabel";
            this.punctajLabel.Size = new System.Drawing.Size(96, 25);
            this.punctajLabel.TabIndex = 3;
            this.punctajLabel.Text = "Punctaj: ";
            // 
            // itemEnuntTextBox
            // 
            this.itemEnuntTextBox.Location = new System.Drawing.Point(284, 104);
            this.itemEnuntTextBox.Multiline = true;
            this.itemEnuntTextBox.Name = "itemEnuntTextBox";
            this.itemEnuntTextBox.Size = new System.Drawing.Size(694, 95);
            this.itemEnuntTextBox.TabIndex = 2;
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Location = new System.Drawing.Point(183, 107);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(95, 25);
            this.itemLabel.TabIndex = 1;
            this.itemLabel.Text = "Item nr. :";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(23, 19);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(157, 57);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start test";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // carnetTabPage
            // 
            this.carnetTabPage.Controls.Add(this.numeElevLabel);
            this.carnetTabPage.Controls.Add(this.printButton);
            this.carnetTabPage.Controls.Add(this.dataGridViewNote);
            this.carnetTabPage.Location = new System.Drawing.Point(8, 39);
            this.carnetTabPage.Name = "carnetTabPage";
            this.carnetTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.carnetTabPage.Size = new System.Drawing.Size(1199, 561);
            this.carnetTabPage.TabIndex = 1;
            this.carnetTabPage.Text = "Carnet de note";
            this.carnetTabPage.UseVisualStyleBackColor = true;
            // 
            // numeElevLabel
            // 
            this.numeElevLabel.AutoSize = true;
            this.numeElevLabel.Location = new System.Drawing.Point(311, 36);
            this.numeElevLabel.Name = "numeElevLabel";
            this.numeElevLabel.Size = new System.Drawing.Size(72, 25);
            this.numeElevLabel.TabIndex = 2;
            this.numeElevLabel.Text = "          ";
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(891, 209);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(249, 132);
            this.printButton.TabIndex = 1;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // dataGridViewNote
            // 
            this.dataGridViewNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNote.Location = new System.Drawing.Point(39, 115);
            this.dataGridViewNote.Name = "dataGridViewNote";
            this.dataGridViewNote.RowHeadersWidth = 82;
            this.dataGridViewNote.RowTemplate.Height = 33;
            this.dataGridViewNote.Size = new System.Drawing.Size(729, 388);
            this.dataGridViewNote.TabIndex = 0;
            // 
            // graficTabPage
            // 
            this.graficTabPage.Controls.Add(this.chart1);
            this.graficTabPage.Location = new System.Drawing.Point(8, 39);
            this.graficTabPage.Name = "graficTabPage";
            this.graficTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.graficTabPage.Size = new System.Drawing.Size(1199, 561);
            this.graficTabPage.TabIndex = 2;
            this.graficTabPage.Text = "Grafic note";
            this.graficTabPage.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(84, 88);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1004, 384);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // eLearning2018_Elev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 695);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "eLearning2018_Elev";
            this.Text = "eLearning2018_Elev";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.testeTabPage.ResumeLayout(false);
            this.testeTabPage.PerformLayout();
            this.carnetTabPage.ResumeLayout(false);
            this.carnetTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNote)).EndInit();
            this.graficTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem elevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carnetDeNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficNoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage testeTabPage;
        private System.Windows.Forms.TabPage carnetTabPage;
        private System.Windows.Forms.TabPage graficTabPage;
        private System.Windows.Forms.TextBox itemEnuntTextBox;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button raspundeButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label punctajLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewNote;
        private System.Windows.Forms.Label numeElevLabel;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}