using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace random_örneği_1681
{ 
    public partial class btnUret : Form
    {
        public btnUret()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           lbNotlar.Items.Clear();
            Random rnd = new Random();

            for(int i = 0; i < 15; i++)
            {
                int puam = rnd.Next(0,100);
                lbNotlar.Items.Add(puam);
            }
            
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbNotlar.Items.Clear();
            Random rnd = new Random();

            for (int i = 0; i < 15; i++)
            {
                int puam = rnd.Next(0, 100);
                lbNotlar.Items.Add(puam);
            }
        }
    }
}
