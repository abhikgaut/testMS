using businessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace testMS
{
    public partial class date : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            blClass b = new blClass();
            try
            {
                int age = b.calculate(DateTime.Parse(TextBox1.Text));
                Label1.Text = "age is :"+age.ToString();
            }
            catch (Exception E)
            {
                Response.Write(E.Message);
            }
        }
    }
}