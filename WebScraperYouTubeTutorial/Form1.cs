using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;






namespace WebScraperYouTubeTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonScrape_Click(object sender, EventArgs e)
        {

            string url = TextBoxURL.Text;

            //GetSoure returns sourcecode text
            string sSourceCode = WorkerClass.GetSourceCode(url);

            WorkerClass.WriteSourceToText(sSourceCode);

            WorkerClass.ParseData(sSourceCode);


        }










    }
}
