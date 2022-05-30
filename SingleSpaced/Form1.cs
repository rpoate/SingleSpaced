using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleSpaced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.htmlEditControl1.CSSText = "body {font-family: Arial} p {margin-top: 0; margin-bottom: 0}";
            this.htmlEditControl1.ToolStripItems.Add("Show HTML").Click += ShowCode;
        }

        private void ShowCode(object sender, EventArgs e)
        {
            MessageBox.Show(this.htmlEditControl1.DocumentHTML);
        }

        private void htmlEditControl1_BeforeGetDocumentHTML(object sender, Zoople.BeforeGetDocumentHTMLEventArgs e)
        {
            e.htmlSource = e.htmlSource.Replace("<p", "<div");
            e.htmlSource = e.htmlSource.Replace("/p>", "/div>");
        }
    }
}
