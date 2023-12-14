using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Rec1
{
    public partial class CrearPrecio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCrearPrecio_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text.Trim();
            string monto = txtMonto.Text.Trim();
            string idProducto = txtIdProducto.Text.Trim();

            if (string.IsNullOrEmpty(fecha) || string.IsNullOrEmpty(monto) || string.IsNullOrEmpty(idProducto))
            {
                lblMensaje.Text = "Los campos Fecha, Monto e ID de Producto no pueden estar vacíos.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
                return;
            }

            if (!DateTime.TryParse(fecha, out DateTime fechaValue) || !int.TryParse(monto, out int montoValue) || !int.TryParse(idProducto, out int idProductoValue))
            {
                lblMensaje.Text = "Ingrese valores válidos para Fecha (YYYY-MM-DD), Monto e ID de Producto.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                lblMensaje.Visible = true;
                return;
            }

            string s = System.Configuration.ConfigurationManager.ConnectionStrings["administracion"].ConnectionString;

            using (SqlConnection con = new SqlConnection(s))
            {
                con.Open();
                string query = "INSERT INTO precios (fecha, monto, idProducto) VALUES (@fecha, @monto, @idProducto)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@fecha", fechaValue);
                    cmd.Parameters.AddWithValue("@monto", montoValue);
                    cmd.Parameters.AddWithValue("@idProducto", idProductoValue);
                    cmd.ExecuteNonQuery();
                }
            }

            lblMensaje.Text = "Precio agregado correctamente";
            lblMensaje.ForeColor = System.Drawing.Color.Green;
            lblMensaje.Visible = true;
        }
    }
}