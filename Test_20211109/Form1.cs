using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_20211109
{
    public partial class Form1 : Form
    {
        Ucet ucet1;

        public Form1()
        {                                   
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ucet ucet1 = new Ucet("Lukáš Krejčí", 3500);
            Vypis(ucet1);

        }
        private void Vypis(Ucet ucet)
        {
            vypisJmeno.Text = ucet.jmeno;
            vypisZustatek.Text = ""+ucet.zustatek;
        }

        private void vkladB_Click(object sender, EventArgs e)
        {
            ucet1.Vklad((int)vkladN.Value);        //úplně nechápu co je špatně
            Vypis(ucet1);
           // vypisZustatek.Text = "" + ucet1.zustatek;
            
        }

        private void vybratB_Click(object sender, EventArgs e)
        {
            ucet1.Vyber((int)vyberN.Value);        //úplně nechápu co je špatně
            Vypis(ucet1);
        }

        private void platbaB_Click(object sender, EventArgs e)
        {
            ucet1.Plat((int)platbaN.Value);           //úplně nechápu co je špatně
            Vypis(ucet1);




            //alespoň za 4 prosím
        }
    }
}
