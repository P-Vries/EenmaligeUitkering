using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EenmaligeUitkering
{
    public partial class Form1 : Form
    {
        //
        //Vars
        //
        double betaal;
        DateTime Nu = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        //
        //Methodes
        //
        private void Bereken()
        {
            betaal = (double.Parse(txbSalaris.Text) / 100) * 1.75;
            int leeftijd = dtpGeboorteDatum.Value.Year - Nu.Year;
            if(leeftijd < 21)
            {
                if (chbGetrouwd.Checked =! true)
                {
                    if(betaal > 1300)
                    {
                        betaal = 1300;
                    }
                }
            }
            else
            {
                if(betaal > 1425)
                {
                    betaal = 1425;
                }
            }
            if (betaal < 250)
            {
                betaal = 250;
            }
            lblTotaal.Text = "Totaal: " + betaal.ToString();
            betaal = 0;
        }

        //
        //Events
        //
        private void btnBereken_Click(object sender, EventArgs e)
        {
            Bereken();
        }
    }
}
