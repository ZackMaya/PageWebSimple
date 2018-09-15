using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Espacio de nombres para conección
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoWebServicioSocial
{
    public partial class index : System.Web.UI.Page
    {
        //Conección MySQL
        string connectionString = @"Server=localhost;Database=listaproductos;Uid=root;Pwd=root;";


        protected void Page_Load(object sender, EventArgs e)
        {
            GridFill();
          

        }

        //Método mostrar lista de prodcutos a través de Grill
        void GridFill()
        {
            using (MySqlConnection sqlConexion = new MySqlConnection(connectionString))
            {
                sqlConexion.Open();
                MySqlDataAdapter sqlProduct = new MySqlDataAdapter("ver_productos",sqlConexion);
                sqlProduct.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                sqlProduct.Fill(datatable);
                getProducto.DataSource = datatable;
                getProducto.DataBind();
            }
        }

        //Métodos para usar los filtros y ejecutar los Join en las base de datos
        //Se podría mejorar y optimizar el código usando un combo box


        protected void btnpreciodesc_Click1(object sender, EventArgs e)
        {
            using (MySqlConnection sqlConexion = new MySqlConnection(connectionString))
            {
                sqlConexion.Open();
                MySqlDataAdapter sqlProduct = new MySqlDataAdapter("precio_desc", sqlConexion);
                sqlProduct.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                sqlProduct.Fill(datatable);
                getProducto.DataSource = datatable;
                getProducto.DataBind();
            }
        }

        protected void btnprecioasc_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlConexion = new MySqlConnection(connectionString))
            {
                sqlConexion.Open();
                MySqlDataAdapter sqlProduct = new MySqlDataAdapter("precio_asc", sqlConexion);
                sqlProduct.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                sqlProduct.Fill(datatable);
                getProducto.DataSource = datatable;
                getProducto.DataBind();
            }

        }

        protected void btnexistenciadesc_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlConexion = new MySqlConnection(connectionString))
            {
                sqlConexion.Open();
                MySqlDataAdapter sqlProduct = new MySqlDataAdapter("exis_desc", sqlConexion);
                sqlProduct.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                sqlProduct.Fill(datatable);
                getProducto.DataSource = datatable;
                getProducto.DataBind();
            }

        }

        protected void btnexistenciaasc_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlConexion = new MySqlConnection(connectionString))
            {
                sqlConexion.Open();
                MySqlDataAdapter sqlProduct = new MySqlDataAdapter("exis_asc", sqlConexion);
                sqlProduct.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                sqlProduct.Fill(datatable);
                getProducto.DataSource = datatable;
                getProducto.DataBind();
            }

        }

        protected void btnalfadesc_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlConexion = new MySqlConnection(connectionString))
            {
                sqlConexion.Open();
                MySqlDataAdapter sqlProduct = new MySqlDataAdapter("alfa_desc", sqlConexion);
                sqlProduct.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                sqlProduct.Fill(datatable);
                getProducto.DataSource = datatable;
                getProducto.DataBind();
            }

        }

        protected void btnalfaasc_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlConexion = new MySqlConnection(connectionString))
            {
                sqlConexion.Open();
                MySqlDataAdapter sqlProduct = new MySqlDataAdapter("alfa_asc", sqlConexion);
                sqlProduct.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
                DataTable datatable = new DataTable();
                sqlProduct.Fill(datatable);
                getProducto.DataSource = datatable;
                getProducto.DataBind();
            }
        }

     

    }
}