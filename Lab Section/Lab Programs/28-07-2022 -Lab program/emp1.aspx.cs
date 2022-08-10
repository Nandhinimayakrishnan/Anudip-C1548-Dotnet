using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// List of employees is available in listbox.Write an application to add selected or all records from listbox(assume multi-line property of textbox is true).
namespace WebApplication19
{
    public partial class emp1 : System.Web.UI.Page
    {
        String empname = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListItem l1 in ListBox1.Items)
            {
                if(l1.Selected)
                {
                    empname = empname + l1.Value;
                }
            }
            TextBox1.Text = TextBox1.Text + "\n" + empname;
        }
    }
}