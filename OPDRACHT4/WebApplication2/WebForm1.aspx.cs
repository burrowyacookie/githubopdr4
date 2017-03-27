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

        protected void btnActie_Click(object sender, EventArgs e)
        {

            DateTime nu = DateTime.Now;
            TimeSpan objTimeSpan = new TimeSpan(2, 10, 15, 3);
            DateTime toekomst = nu.Add(objTimeSpan);
            litVandaag.Text = toekomst.ToString();


        }

        protected void btnLaden_Click(object sender, EventArgs e)
        {

           
            DateTime Nu = DateTime.Now;
            string NuDatum = " " + Nu;
            Response.Write(DateTime.Now.ToString("hh.mm"));
            DateTime Tijd = new DateTime(2017, 4, 16, 0, 0, 0);
            string TijdDatum = " " + Tijd;

            //Trek nu van pasen af
            TimeSpan objTimeSpan = Tijd.Subtract(Nu);

            //Aantal uren
            int dagen = objTimeSpan.Days;
            int uren = objTimeSpan.Hours;
            int minuten = objTimeSpan.Minutes;
            int seconden = objTimeSpan.Seconds;
            int totaaluren = dagen * 24 + uren;

            string PasenDatum = "dagen: " + dagen + "<br>" +
                "uren: " + uren + "<br>" +
                "minuten: " + minuten + "<br>" +
                "seconden: " + seconden;

            litVandaag.Text = NuDatum;
            litTijd.Text = TijdDatum;
            litPasen.Text = PasenDatum;

        }
    }
}


  