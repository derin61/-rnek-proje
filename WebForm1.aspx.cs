using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webproje1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sayia, sayib;
           

            sayia = Convert.ToInt32(txt_a.Text);
            sayib = Convert.ToInt32(txt_b.Text);
            int toplam = sayia + sayib;
            Btn_1.Text = "=" + toplam;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}