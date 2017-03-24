using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class calculator : System.Web.UI.Page
{
    calc mycalc = new calc();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        decimal oper1 = Convert.ToDecimal(TextBox1.Text);
        decimal oper2 = Convert.ToDecimal(TextBox2.Text);
        arithmeticresults.Text = mycalc.Add(oper1, oper2).ToString();
        errorslabel.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        decimal oper1 = Convert.ToDecimal(TextBox1.Text);
        decimal oper2 = Convert.ToDecimal(TextBox2.Text);
        arithmeticresults.Text = mycalc.Subtract(oper1, oper2).ToString();
        errorslabel.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        decimal oper1 = Convert.ToDecimal(TextBox1.Text);
        decimal oper2 = Convert.ToDecimal(TextBox2.Text);
        arithmeticresults.Text = mycalc.Multiply(oper1, oper2).ToString();
        errorslabel.Text = "";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        decimal oper1 = Convert.ToDecimal(TextBox1.Text);
        decimal oper2 = Convert.ToDecimal(TextBox2.Text);
        if(oper2 != 0) {
            arithmeticresults.Text = mycalc.Divide(oper1, oper2).ToString();
            errorslabel.Text = "";
        }
        else
        {
            errorslabel.Text = "Division by 0 not allowed.";
            arithmeticresults.Text = "";
        }
    }
}