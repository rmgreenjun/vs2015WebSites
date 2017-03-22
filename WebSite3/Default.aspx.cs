using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    sampleclass sc = new sampleclass();
    //creates instance of sampleclass
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text = sc.Add(2, 4).ToString();
        //adds 2 & 4, converts the result to a string, then displays this string in label1
    }
}