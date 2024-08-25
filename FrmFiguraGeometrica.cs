using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evaluacionPractica
{
    public partial class FrmFiguraGeometrica : Form
    {
        private Stack<Poligono> pilaPoligonos = new Stack<Poligono>();

        public FrmFiguraGeometrica()
        {
            InitializeComponent();
        }

        private void btnCalcularTriangulo_Click(object sender, EventArgs e)
        {
            

            if (txtBaseT.Text==string.Empty || txtAlturaT.Text==string.Empty)
            {

                MessageBox.Show("Falta datos o son incorrectos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                lblresultadoTriangulo.Text = "";
            }
            else
            {
                double baseTriangulo = double.Parse(txtBaseT.Text.Trim());
                double altura = double.Parse(txtAlturaT.Text.Trim());
                Triangulo triangulo = new Triangulo("Triángulo", baseTriangulo, altura);
                lblresultadoTriangulo.Text = Convert.ToString(triangulo.ToString());
                pilaPoligonos.Push(triangulo);
            }

        }

        private void btnCalcularRectangulo_Click(object sender, EventArgs e)
        {
            

            if (txtLargo.Text == string.Empty || txtAncho.Text == string.Empty)
            {
                MessageBox.Show("Falta datos o son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblresultadoRectangulo.Text = "";
            }
            else
            {
                double largo = double.Parse(txtLargo.Text.Trim());
                double ancho = double.Parse(txtAncho.Text.Trim());
                Rectangulo rectangulo = new Rectangulo("Rectángulo",largo,ancho);
                lblresultadoRectangulo.Text = Convert.ToString(rectangulo.ToString());
                pilaPoligonos.Push(rectangulo);
            }

        }

        private void picLimpiarT_Click(object sender, EventArgs e)
        {
            txtBaseT.Clear();
            txtAlturaT.Clear();
        }

        private void picLimpiarR_Click(object sender, EventArgs e)
        {
            txtLargo.Clear();
            txtAncho.Clear();
        }

        private void btnCalcularParalelogramo_Click(object sender, EventArgs e)
        {
           

            if (txtBaseP.Text == string.Empty || txtAlturaP.Text == string.Empty)
            {
                MessageBox.Show("Falta datos o son incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblResultadoParalelogramo.Text = "";
            }
            else
            {
                double baseParalelo = double.Parse(txtBaseP.Text.Trim());
                double altura = double.Parse(txtAlturaP.Text.Trim());
                Paralelogramo paralelogramo = new Paralelogramo("Paralelogramo",baseParalelo,altura);
                lblResultadoParalelogramo.Text = Convert.ToString(paralelogramo.ToString());
                pilaPoligonos.Push(paralelogramo);
            }
        }

        private void picLimpiarP_Click(object sender, EventArgs e)
        {
            txtBaseP.Clear();
            txtAlturaP.Clear();
        }

        private void btnMostrarPila_Click(object sender, EventArgs e)
        {
            lblPila.Text = "";
            if (pilaPoligonos.Count <=0)
            {
                lblPila.Text = "El registro de Pila está vacio.";
            }
            else
            {
                foreach (var poligono in pilaPoligonos)
                {
                    lblPila.Text += poligono.ToString() + "\n\n";
                }
            }

        }

        private void FrmFiguraGeometrica_Load(object sender, EventArgs e)
        {
            txtBaseT.Focus();
            txtBaseT.Clear();
            txtAlturaT.Clear();
            txtBaseP.Clear();
            txtAlturaP.Clear();
            txtLargo.Clear();
            txtAncho.Clear();
            lblresultadoTriangulo.Text = "";
            lblresultadoRectangulo.Text = "";
            lblResultadoParalelogramo.Text = "";
            lblPila.Text = "";
           
        }
    }
}
