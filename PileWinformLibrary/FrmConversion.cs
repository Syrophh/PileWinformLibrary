using MesOutils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PileWinformLibrary
{
    public partial class maskedTextBox1 : Form
    {
        public maskedTextBox1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            Int32 NbAConvertir = 0, Resultat, Reste;
            Int16 NewBase = 0;
            txtResultat.Clear();
            try
            {
                NbAConvertir = Int32.Parse(mskNbAConvertir.Text);
                NewBase = Int16.Parse(nudNouvelleBase.Text);
                Pile<int> Wonder = new Pile<int>(15);
                Resultat = NbAConvertir;
                //Reste = 0;
                while (Resultat != 0) ;
                {
                    Reste = Resultat % NewBase;
                    Resultat = Resultat / NewBase;
                    Wonder.Empiler(Reste);
                }
                while (!Wonder.PileVide()) ;
                {
                    int retour = Wonder.Depiler();
                    if (retour < 10)
                        txtResultat.Text += retour.ToString();
                    else
                        txtResultat.Text += +(System.Convert.ToChar(55 + retour));
                }
            }

            catch (OverflowException oex)
            {
                MessageBox.Show("Nombre trop grand");
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Seuls les entiers sont acceptés");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
