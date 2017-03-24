using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int x = Convert.ToInt16(TextBox1.Text); //convert the textbox text to a number
        int y = x * x; //assign x squared to y
        Label1.Text = y.ToString(); //convert y to a string. display as label text.
    }
}