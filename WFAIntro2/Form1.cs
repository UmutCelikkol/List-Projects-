using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAIntro2
{
    public partial class Form1 : Form
    {
        //Eger Form üzerine bir kontrol atarsanız onu kod tarafında kullanacaksanız name özelligini kesinlikle belirleyin...

            //Kod tarafında bir kontrolün özelliklerine ulasmak istiyorsanız önce o kontrolün kimligini yazmalısınız...Sonra . sembolünü kullanarak ilgili özellikler kümesine ve aynı zamanda eventler kümesine ulasabilirsiniz.




        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            btnDegistir.Text ="Degişen yazı" ;
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            btnRenk.BackColor = Color.Aqua;
        }

        private void btnYokEt_Click(object sender, EventArgs e)
        {
            txtAlan.Visible = lblYazi.Visible = false;
        }

        private void txtAlan_TextChanged(object sender, EventArgs e)
        {
            lblYazi.Text = txtAlan.Text;

            
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            //this.Text = "asdsad";
            Text = "asdsad";
        }
    }
}
