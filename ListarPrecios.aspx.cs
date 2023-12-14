using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rec1
{
    public partial class ListarPrecios : System.Web.UI.Page
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
                string query = "SELECT id, fecha, monto, idProducto FROM precios WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", idBuscar);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtId.Text = reader["id"].ToString();
                            txtFecha.Text = reader["fecha"].ToString();
                            txtMonto.Text = reader["monto"].ToString();
                            txtIdProducto.Text = reader["idProducto"].ToString();
                            lblMensaje.Text = "";
                        }
                        else
                        {
                            txtId.Text = "";
                            txtFecha.Text = "";
                            txtMonto.Text = "";
                            txtIdProducto.Text = "";
                            lblMensaje.Text = "No se encontró ningún precio con el ID proporcionado.";
                        }
                    }
                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text.Trim();
            string nuevaFecha = txtFecha.Text.Trim();
            string nuevoMonto = txtMonto.Text.Trim();
            string nuevoIdProducto = txtIdProducto.Text.Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(nuevaFecha) || string.IsNullOrEmpty(nuevoMonto) || string.IsNullOrEmpty(nuevoIdProducto))
            {
                lblMensaje.Text = "Los campos ID, Fecha, Monto e ID de Producto no pueden estar vacíos.";
                return;
            }

            if (!DateTime.TryParse(nuevaFecha, out DateTime fechaValue) || !int.TryParse(nuevoMonto, out int montoValue) || !int.TryParse(nuevoIdProducto, out int idProductoValue))
            {
                lblMensaje.Text = "Ingrese valores válidos para Fecha, Monto e ID de Producto.";
                return;
            }

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["administracion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "UPDATE precios SET fecha = @fecha, monto = @monto, idProducto = @idProducto WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@fecha", fechaValue);
                    cmd.Parameters.AddWithValue("@monto", montoValue);
                    cmd.Parameters.AddWithValue("@idProducto", idProductoValue);
                    cmd.ExecuteNonQuery();
                    lblMensaje.Text = "Precio actualizado correctamente.";
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
                string query = "DELETE FROM precios WHERE id = @id";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        lblMensaje.Text = "Precio eliminado correctamente.";
                        txtId.Text = "";
                        txtFecha.Text = "";
                        txtMonto.Text = "";
                        txtIdProducto.Text = "";
                    }
                    else
                    {
                        lblMensaje.Text = "No se encontró ningún precio con el ID proporcionado.";
                    }
                }
            }
        }
    }
}