using businessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testMS
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            blClass b = new blClass();
            try
            {
                TextBox3.Text = b.Divide(TextBox1.Text , TextBox2.Text).ToString();
            }
            catch (DivideByZeroException E)
            {
                Response.Write(E.Message);
            }
        }
    }
}