using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string a, b;
            a = TextBox1.Text;
            b = TextBox2.Text;
            Label1.Text = a + b;
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 0)
                Label1.ForeColor = System.Drawing.Color.Red;
            if (RadioButtonList1.SelectedIndex == 1)
                Label1.ForeColor = System.Drawing.Color.Blue;
            if (RadioButtonList1.SelectedIndex == 2)
                Label1.ForeColor = System.Drawing.Color.Orange;
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CheckBoxList1.SelectedIndex==0)
                Label1.Font.Bold = true;
             if (CheckBoxList1.SelectedIndex==1)
                Label1.Font.Italic = true;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
 }