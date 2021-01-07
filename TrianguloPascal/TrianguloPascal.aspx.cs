using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrianguloPascal
{
    public partial class TrianguloPascal : System.Web.UI.Page
    {
        int fact, a, c, comb, h, i;
        int j, k, n, r;    /*   variables  globales */
        public int factorial(int n)
        {
            //factorial   
            if (n == 0)
            {
                fact = 1;
            }
            else
            {
                fact = 1;
                for (a = 1; a <= n; a++)
                    fact = fact * a;
            }
            c = fact;
            return c;
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<center><br><br>");
            Response.Write("****** Triangulo de Pascal *********");
            Response.Write("<br><br>");

            Response.Write("1");
            for (n = 1; n <= 7; n++)
            {
                Response.Write("<br>");
                for (r = 0; r <= 7; r++)
                {
                    h = factorial(n);
                    k = (n - r);
                    i = factorial(k);
                    
                    j = factorial(r);
                    comb = h / (i * j);
                    if (comb == 0)
                        Response.Write(" ");
                    else
                    {
                        Response.Write(comb.ToString("g"));
                    }
                }
            }
            Response.Write("</center><br><br>");
        }
    }
}
