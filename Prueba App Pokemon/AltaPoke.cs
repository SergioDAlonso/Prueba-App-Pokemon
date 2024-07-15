using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Configuration;

namespace Prueba_App_Pokemon
{
    public partial class frmAltaPoke : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;
        public frmAltaPoke()
        {
            InitializeComponent();
        }
        public frmAltaPoke(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            PokemonNegocio negocio = new PokemonNegocio();
            try
            {
                if (pokemon == null) 
                    pokemon = new Pokemon();
                pokemon.Numero = int.Parse(txbNumero.Text);
                pokemon.Nombre = TxbNombre.Text;
                pokemon.Descripcion = TxbDescripcion.Text;
                pokemon.Urlimagen = txbUrlImagen.Text;
                pokemon.Tipo = (Elemento)cbxTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cbxDebilidad.SelectedItem;

                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente.");
                    Close();
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente.");
                }
                if (archivo != null && !(txbUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagen-folder"] + archivo.SafeFileName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaPoke_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();
            try
            {
                cbxTipo.DataSource = elementoNegocio.listar();
                cbxTipo.ValueMember = "Id";
                cbxTipo.DisplayMember = "Descripcion";
                cbxDebilidad.DataSource = elementoNegocio.listar();
                cbxDebilidad.ValueMember = "Id";
                cbxDebilidad.DisplayMember = "Descripcion";

                if (pokemon != null)
                {
                    txbNumero.Text = pokemon.Numero.ToString();
                    TxbNombre.Text = pokemon.Nombre;
                    TxbDescripcion.Text = pokemon.Descripcion;
                    txbUrlImagen.Text = pokemon.Urlimagen;
                    cargarImagen(pokemon.Urlimagen);
                    cbxTipo.SelectedValue = pokemon.Tipo.Id;
                    cbxDebilidad.SelectedValue = pokemon.Debilidad.Id;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void txbUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txbUrlImagen.Text);
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

        private void bttAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txbUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
