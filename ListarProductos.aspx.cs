using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rec1
{
    public partial class ListarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string idBuscar = txtBuscarId.Text.Trim();
            if (!int.TryParse(idBuscar, out int id))
            {
                lblMensaje.Text = "Ingrese un ID válido (solo números).";
                return;
            }

            if (string.IsNullOrEmpty(idBuscar))
            {
                lblMensaje.Text = "Ingrese un ID válido para buscar.";
                return;
            }

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["administracion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "SELECT id, descripcion FROM productos WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", idBuscar);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtId.Text = reader["id"].ToString();
                            txtDescripcion.Text = reader["descripcion"].ToString();
                            lblMensaje.Text = "";
                        }
                        else
                        {
                            txtId.Text = "";
                            txtDescripcion.Text = "";
                            lblMensaje.Text = "No se encontró ningún producto con el ID proporcionado.";
                        }
                    }
                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string nuevaDescripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nuevaDescripcion))
            {
                lblMensaje.Text = "Los campos ID y Descripción no pueden estar vacíos.";
                return;
            }

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["administracion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "UPDATE productos SET descripcion = @descripcion WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@descripcion", nuevaDescripcion);
                    cmd.ExecuteNonQuery();
                    lblMensaje.Text = "Descripción actualizada correctamente.";
                }
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();

            if (string.IsNullOrEmpty(id))
            {
                lblMensaje.Text = "El campo ID no puede estar vacío.";
                return;
            }

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["administracion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "DELETE FROM productos WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        lblMensaje.Text = "Producto eliminado correctamente.";
                        txtId.Text = "";
                        txtDescripcion.Text = "";
                    }
                    else
                    {
                        lblMensaje.Text = "No se encontró ningún producto con el ID proporcionado.";
                    }
                }
            }
        }
    }
}