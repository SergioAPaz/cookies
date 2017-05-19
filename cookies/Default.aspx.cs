using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookies
{
    public partial class _Default : Page
    {
        HttpCookie StudentCookies = new HttpCookie("StudentCookies");

        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.Cookies["StudentCookies"] == null)
            {
                StudentCookies.Value = "English";
                StudentCookies.Expires = DateTime.Now.AddDays(7);
                Response.Cookies.Add(StudentCookies);



            }
            else
            {
                string roll = Request.Cookies["StudentCookies"].Value; //For First Way
                if (roll=="Spanish")
                {
                    lblSpanish.Visible = true;

                    lblEnglish.Visible = false;
                }
                else
                {
                    lblSpanish.Visible = false;

                    lblEnglish.Visible = true;
                }
            }
        }

        protected void btnSpanish_Click(object sender, EventArgs e)
        {
            StudentCookies.Value = "Spanish";
            StudentCookies.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(StudentCookies);
            lblSpanish.Visible = true;

            lblEnglish.Visible = false;
        }

        protected void btnEnglish_Click(object sender, EventArgs e)
        {
            StudentCookies.Value = "English";
            StudentCookies.Expires = DateTime.Now.AddDays(7);
            Response.Cookies.Add(StudentCookies);
            lblSpanish.Visible = false;

            lblEnglish.Visible = true;
        }
    }
}