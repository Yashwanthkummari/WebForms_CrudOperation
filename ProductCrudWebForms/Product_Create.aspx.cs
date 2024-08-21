using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Web.UI.WebControls;

namespace ProductCrudWebForms
{
    public partial class Product_Create : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            loadRecord();

        }

     

        protected void Submit_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(cs))
            {
                conn.Open();
                cmd = new SqlCommand("Insert Into Products (ProductId,Name,Brand,Category,Description,Price) values(@productid,@name,@brand,@category,@description,@price)", conn);
                cmd.Parameters.AddWithValue("@productid", txtProdId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@category", txtCat.Text);
                cmd.Parameters.AddWithValue("@description", txtDes.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Sucessfully");
                conn.Close();
                ClearData();
                loadRecord();
            }
        }

        void loadRecord()
        {
            using (conn = new SqlConnection(cs))
            {
                conn.Open();
                cmd = new SqlCommand ("Select * from Products",conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        void ClearData()
        {
            txtProdId.Text = "";
            txtName.Text = "";
            txtBrand.Text = "";
            txtCat.Text = "";
            txtDes.Text = "";
            txtprice.Text = "";


        }
        protected void update_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(cs))
            {
                string query = "UPDATE Products SET Name = @name, Brand = @brand, Category = @category, Description = @description, Price = @price WHERE ProductId = @productId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productid", txtProdId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@brand", txtBrand.Text);
                cmd.Parameters.AddWithValue("@category", txtCat.Text);
                cmd.Parameters.AddWithValue("@description", txtDes.Text);
                cmd.Parameters.AddWithValue("@price", txtprice.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Sucessfully");
                conn.Close();
                ClearData();
                loadRecord();
            }

        }

        protected void delete_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(cs))
            {
                string query = "DELETE FROM Products WHERE ProductId = @productId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@productId", txtProdId.Text);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Sucessfully");
                conn.Close();
                ClearData();
                loadRecord();
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;

            txtProdId.Text = row.Cells[1].Text;
            txtName.Text = row.Cells[2].Text;
            txtBrand.Text = row.Cells[3].Text;
            txtCat.Text = row.Cells[4].Text;
            txtDes.Text = row.Cells[5].Text;
            txtprice.Text = row.Cells[6].Text;

        }


    }
}
