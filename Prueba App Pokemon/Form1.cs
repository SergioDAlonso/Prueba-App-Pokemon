using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using static System.Net.Mime.MediaTypeNames;

namespace Prueba_App_Pokemon
{
    public partial class VtnPrinc : Form
    {
        private List<Pokemon> listapokemons;
        public VtnPrinc()
        {
            InitializeComponent();
        }

        private void VtnPrinc_Load(object sender, EventArgs e)
        {
            cargar();
            cbxCampo.Items.Add("Numero");
            cbxCampo.Items.Add("Nombre");
            cbxCampo.Items.Add("Descripcion");
        }

        private void cargar()
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                listapokemons = negocio.listar();
                dgvprincipal.DataSource = listapokemons;
                ocultarColumnas();
                cargarImagen(listapokemons[0].Urlimagen);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
            dgvprincipal.Columns["UrlImagen"].Visible = false;
            dgvprincipal.Columns["Id"].Visible = false;
        }

        private void dgvprincipal_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvprincipal.CurrentRow != null)
            {
                Pokemon selecionado = (Pokemon)dgvprincipal.CurrentRow.DataBoundItem;
                cargarImagen(selecionado.Urlimagen);
            }
        }

    private void cargarImagen(string imagen)
        {
            try
            {
                Pbxprincipal.Load(imagen);
            }
            catch (Exception)
            {
                Pbxprincipal.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            } 
        }

        private void bttAgregar_Click(object sender, EventArgs e)
        {
           frmAltaPoke alta = new frmAltaPoke();
            alta.ShowDialog();
            cargar();
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttModificar_Click(object sender, EventArgs e)
        {
            Pokemon seleccionado;
            seleccionado = (Pokemon)dgvprincipal.CurrentRow.DataBoundItem;
            frmAltaPoke Modificar = new frmAltaPoke(seleccionado);
            Modificar.ShowDialog();
            cargar();
        }

        private void bttEliFi_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void bttEliLog_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }
        private void eliminar( bool logico = false)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            Pokemon seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Pokemon)dgvprincipal.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarlogico(seleccionado.Id);
                    else
                        negocio.eliminar(seleccionado.Id);

                    MessageBox.Show("Eliminado");
                    cargar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el campo elegido.");
                return true;
            }if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, seleccione el criterio elegido.");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Numero")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanz.Text))
                {
                    MessageBox.Show("Debes cargar un Nro.");
                    return true;
                }
                
                if (!(soloNumeros(txtFiltroAvanz.Text))) {
                    MessageBox.Show("Ingrese solo numeros para filtrar.");
                    return true;
                }
            }
            return false;
        }
        private bool soloNumeros(string cadenas)
        {
            foreach (char caracter in cadenas)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
            

        private void bttFiltro_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (validarFiltro())
                    return;
                string Campo = cbxCampo.SelectedItem.ToString();
                string Criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanz.Text;
                dgvprincipal.DataSource = negocio.filtrar(Campo, Criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Pokemon> listaFiltrada;
            string filtro = txtFiltro.Text;
            if (filtro != "")
                listaFiltrada = listapokemons.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Tipo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            else
                listaFiltrada = listapokemons;


            dgvprincipal.DataSource = null;
            dgvprincipal.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbxCampo.SelectedItem.ToString();
            if ( opcion == "Numero")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }
    }
}
