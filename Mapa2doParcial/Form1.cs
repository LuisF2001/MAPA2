using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mapa2doParcial
{
    public partial class MAPA : Form
    {
        public MAPA()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string calle = txtCalle.Text;
            string barrio = txtBarrio.Text;
            string sector = txtSector.Text;
            string ciudad = txtCiudad.Text;
            string provincia = txtProvincia.Text;
            StringBuilder queryaddress = new StringBuilder();

            queryaddress.Append("http://google.com/maps?q=");
                if (calle != string.Empty)
            {
                queryaddress.Append(calle + "," + "+");
            }
            if (barrio != string.Empty)
            {
                queryaddress.Append(barrio + "," + "+");
            }
            if (sector != string.Empty)
            {
                queryaddress.Append(sector + "," + "+");
            }
            if (ciudad != string.Empty)
            {
                queryaddress.Append(ciudad + "," + "+");
            }
            if (provincia != string.Empty)
            {
                queryaddress.Append(provincia + "," + "+");
            }

            webBrowser1.Navigate(queryaddress.ToString());


        }
    }
}
