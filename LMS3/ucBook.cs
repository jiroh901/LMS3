using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS3
{
    public partial class ucBook : UserControl
    {
        public ucBook()
        {
            InitializeComponent();
        }
        private void tbISBN_Click(object sender, EventArgs e)
        {
            tbISBN.BackColor = Color.WhiteSmoke;
            pnlISBN.BackColor = Color.WhiteSmoke;
            tbTitle.BackColor = Color.White;
            pnlTitle.BackColor = Color.White;
            tbPublisher.BackColor = Color.White;
            pnlPublisher.BackColor = Color.White;
        }
        private void tbTitle_Click(object sender, EventArgs e)
        {
            tbISBN.BackColor = Color.White;
            pnlISBN.BackColor = Color.White;
            tbTitle.BackColor = Color.WhiteSmoke;
            pnlTitle.BackColor = Color.WhiteSmoke;
            tbPublisher.BackColor = Color.White;
            pnlPublisher.BackColor = Color.White;
        }
        private void tbPublisher_Click(object sender, EventArgs e)
        {
            tbISBN.BackColor = Color.White;
            pnlISBN.BackColor = Color.White;
            tbTitle.BackColor = Color.White;
            pnlTitle.BackColor = Color.White;
            tbPublisher.BackColor = Color.WhiteSmoke;
            pnlPublisher.BackColor = Color.WhiteSmoke;
        }
    }
}
