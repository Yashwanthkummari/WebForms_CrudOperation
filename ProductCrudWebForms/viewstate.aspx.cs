using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductCrudWebForms
{
    public partial class viewstate : System.Web.UI.Page
    {

        string a,b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       
        

        protected void submit_Click(object sender, EventArgs e)
        {
           /* a=txtName.Text;
            b=txtCity.Text;*/

            ViewState["user"] = txtName.Text;
            ViewState["city"] = txtCity.Text;

            txtName.Text = string.Empty;
            txtCity.Text = string.Empty;
            
        }

        protected void restore_Click(object sender, EventArgs e)
        {
            /*  txtName.Text =a;
              txtCity.Text =b;*/

            if (ViewState["user"] != null)
            {
               txtName.Text = ViewState["user"].ToString();
            }

            if (ViewState["city"] != null)
            {
                txtCity.Text = ViewState["city"].ToString();

            }

        }
    }
}