using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDFJoin
{
    public partial class frmPdfJoin : Form
    {
        public frmPdfJoin()
        {
            InitializeComponent();
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            if (MyPdf.PdfJoin(txtOutput.Text, new string[] { txtPdf1.Text, txtPdf2.Text }))
            {
                displayMessage("ファイルを結合しました。");
            }
            else 
            {
                displayMessage("ファイルの結合に失敗しました。");
            }
        }

        private void displayMessage(string message) 
        {
            lblMessage.Text = DateTime.Now.ToString("HH:mm:ss.fff　") + message;
        }
    }
}
