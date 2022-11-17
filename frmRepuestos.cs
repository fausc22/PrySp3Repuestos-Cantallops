using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySp3Repuestos_Cantallops
{
    public partial class frmRepuestos : Form
    {
        public struct REPUESTO
        {
            public string Marca;
            public string Origen;
            public int Numero;
            public string Descripcion;
            public float Precio;
        };

        const int MAX = 100;
        public REPUESTO[] repuestos;
        public int Cantidad = 0;
        public frmRepuestos()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (validarDatos())
            {
                repuestos[Cantidad].Marca = LstMarca.Text;
                repuestos[Cantidad].Origen = LstOrigen.Text;
                repuestos[Cantidad].Numero = int.Parse(txtNumero.Text);
                repuestos[Cantidad].Precio = int.Parse(txtPrecio.Text);
                repuestos[Cantidad].Descripcion = txtDescripcion.Text;
                Cantidad++;
                if (Cantidad == MAX)    
                {
                    MessageBox.Show("Se completo la capacidad de carga de Datos",
                         "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnRegistrar.Enabled = false;
                }
                Limpiador();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            repuestos = new REPUESTO[MAX];
            Cantidad = 0;
            
            
        }

        private bool validarDatos()
        {
            bool resultado = false;
            if (LstMarca.Text != "" && LstOrigen.Text != "" && txtNumero.Text != "" && txtPrecio.Text != "" && txtDescripcion.Text != "")
            {
                if (!buscarRepuesto(int.Parse(txtNumero.Text)))
                {
                    resultado = true;
                }
                else
                {
                    MessageBox.Show("El Repuesto ingresado ya existe",
                         "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes",
                     "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        private bool buscarRepuesto(int Numero)
        {
            bool existe = false;
            int pos = 0;
            while (pos < Cantidad)
            {
                if (Numero == repuestos[pos].Numero)
                {
                    existe = true;
                    break;
                }
                pos++;
            }
            return existe;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtDescripcionConsulta.Text = "";

            for (int i = 0; i < repuestos.Length; i++)
            {
                if (optImportado.Checked)
                {
                    if (repuestos[i].Origen == "I")
                    {
                        if (repuestos[i].Marca == "P")
                        {
                            txtDescripcionConsulta.Text = txtDescripcionConsulta.Text + "Nro: " + repuestos[i].Numero.ToString() + " " + "Precio: " + repuestos[i].Precio.ToString() + "" + "Descripcion" + " " + repuestos[i].Descripcion.ToString();
                        }
                        else
                        {
                            if (repuestos[i].Marca == "F")
                            {
                                txtDescripcionConsulta.Text = txtDescripcionConsulta.Text + "Nro: " + repuestos[i].Numero.ToString() + " " + "Precio: " + repuestos[i].Precio.ToString() + "" + "Descripcion" + " " + repuestos[i].Descripcion.ToString();
                            }
                            else
                            {
                                txtDescripcionConsulta.Text = txtDescripcionConsulta.Text + "Nro: " + repuestos[i].Numero.ToString() + " " + "Precio: " + repuestos[i].Precio.ToString() + "" + "Descripcion" + " " + repuestos[i].Descripcion.ToString();
                            }
                        }
                        
                        
                            
                    }
                }
                if (optNacional.Checked)
                {
                    if (repuestos[i].Origen == "N")
                    {
                        if (repuestos[i].Marca == "P")
                        {
                            txtDescripcionConsulta.Text = txtDescripcionConsulta.Text + "Nro: " + repuestos[i].Numero.ToString() + " " + "Precio: " + repuestos[i].Precio.ToString() + "" + "Descripcion" + " " + repuestos[i].Descripcion.ToString();
                        }
                        else
                        {
                            if (repuestos[i].Marca == "F")
                            {
                                txtDescripcionConsulta.Text = txtDescripcionConsulta.Text + "Nro: " + repuestos[i].Numero.ToString() + " " + "Precio: " + repuestos[i].Precio.ToString() + "" + "Descripcion" + " " + repuestos[i].Descripcion.ToString();
                            }
                            else
                            {
                                txtDescripcionConsulta.Text = txtDescripcionConsulta.Text + "Nro: " + repuestos[i].Numero.ToString() + " " + "Precio: " + repuestos[i].Precio.ToString() + "" + "Descripcion" + " " + repuestos[i].Descripcion.ToString();
                            }
                        }
                    }
                }
            }

        }
          
       

        private void mrcIngresados_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiador()
        {
            LstMarca.SelectedIndex = -1;
            LstOrigen.SelectedIndex = -1;
            txtNumero.Text = "";
            txtPrecio.Text = "";
            txtDescripcion.Text = "";
            LstMarca.Focus();

        }
    }
}
