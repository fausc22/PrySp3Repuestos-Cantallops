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
            int pos;
            if (LstMarcaConsulta.Text == "P" && optImportado.Enabled)
            {
                for (pos = 0; pos > Cantidad; pos++)
                {
                    if (repuestos[pos].Marca == "P" && repuestos[pos].Origen == "I")
                    {
                        ListBoxRepuestos.Items.Add(repuestos[pos]);
                    }
                
                }
            }
            else
            {
                if (LstMarcaConsulta.Text == "P" && optNacional.Enabled)
                {
                    for (pos = 0;  pos > Cantidad; pos++)
                    {
                        if (repuestos[pos].Marca == "P" && repuestos[pos].Origen == "N")
                        {
                            ListBoxRepuestos.Items.Add(repuestos[pos]);
                        }
                    }
                }
                else
                {
                    if (LstMarcaConsulta.Text == "R" && optImportado.Enabled)
                    {
                        for (pos = 0; pos > Cantidad; pos++)
                        {
                            if (repuestos[pos].Marca == "R" && repuestos[pos].Origen == "I")
                            {
                                ListBoxRepuestos.Items.Add(repuestos[pos]);
                            }
                        }
                    }
                    else
                    {
                        if (LstMarcaConsulta.Text == "R" && optNacional.Enabled)
                        {
                            for (pos = 0; pos > Cantidad; pos++)
                            {
                                if (repuestos[pos].Marca == "R" && repuestos[pos].Origen == "N")
                                {
                                    ListBoxRepuestos.Items.Add(repuestos[pos]);
                                }
                            }
                        }
                        else
                        {
                            if (LstMarcaConsulta.Text == "F" && optImportado.Enabled)
                            {
                                for (pos = 0; pos > Cantidad; pos++)
                                {
                                    if (repuestos[pos].Marca == "F" && repuestos[pos].Origen == "I")
                                    {
                                        ListBoxRepuestos.Items.Add(repuestos[pos]);
                                    }
                                }
                            }
                            else
                            {
                                if (LstMarcaConsulta.Text == "F" && optNacional.Enabled)
                                {
                                    for (pos = 0; pos > Cantidad; pos++)
                                    {
                                        if (repuestos[pos].Marca == "F" && repuestos[pos].Origen == "N")
                                        {
                                            ListBoxRepuestos.Items.Add(repuestos[pos]);
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }
    }
}
