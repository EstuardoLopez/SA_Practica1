using ClientSoap.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSoap
{
    public partial class Form1 : Form
    {
        ClientSOAP clientSoap = null;
        public Form1()
        {
            InitializeComponent();
            this.TxtCantidad.Enabled = false;
        }

        private void BtnAccion_Click(object sender, EventArgs e)
        {
            bool isSelected = this.ChkAccion.Checked;
            ContactoModel filter = new ContactoModel();
            filter.Nombre = TxtNombre.Text;
            if (isSelected)
            {
                if (string.IsNullOrWhiteSpace(TxtNombre.Text))
                {
                    MessageBox.Show("Debe un Nombre");
                    TxtNombre.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(TxtCantidad.Text))
                {
                    MessageBox.Show("Debe ingresar la cantidad de datos que desea enviar");
                    TxtCantidad.Focus();
                    return;
                }

                bool resultParse = Int32.TryParse(TxtCantidad.Text, out int CatidadCrear);
                if (!resultParse)
                {
                    MessageBox.Show("Debe ingresar un datos numerico");
                    TxtCantidad.Focus();
                    return;
                }

                filter.Cantidad = CatidadCrear;
                CrearDatos(filter);
            }
            else
            {
                BuscarDatos(filter);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clientSoap = new ClientSOAP();
        }

        private void chkListAccion_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ChkAccion_CheckedChanged(object sender, EventArgs e)
        {
            bool isSelected = this.ChkAccion.Checked;
            TxtCantidad.Enabled = isSelected;
            BtnAccion.Text = isSelected ? "Guardar" : "Buscar";
        }

        private void BuscarDatos(ContactoModel filter)
        {
            TxtResult.Clear();
            List<ContactoModel> lista = clientSoap.GetContacts(filter);
            foreach (ContactoModel contacto in lista)
            {
                TxtResult.AppendText(contacto.Id.ToString());
                TxtResult.AppendText("\t\t");
                TxtResult.AppendText(contacto.Nombre);
                TxtResult.AppendText("\r\n");
            }

            if (string.Empty.Equals(TxtResult.Text))
            {
                TxtResult.AppendText("Sin Resultados encontrados");
                TxtResult.AppendText("\r\n");
            }
        }

        private void CrearDatos(ContactoModel filter)
        {
            ResponseWS result = clientSoap.SentContacts(filter);
            MessageBox.Show(result.message);
        }

    }
}
