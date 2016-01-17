using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Steam_Powered.Models;

namespace Steam_Powered.Content_Pages
{
    public partial class GamesDefault : System.Web.UI.Page
    {
        private Administratie _admin;

        private List<TableCell> TableCells { get; set; }

        /// <summary>
        /// pagina laden en een tabel weergeven
        /// de tabel word gevuld met de data die in de admin classe staat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            _admin = (Administratie) Session["AdminClass"];

            TableCells = new List<TableCell>();

            GameTable.Width = new Unit("100%");
            GameTable.Height = new Unit("100%");

            int numrows = _admin.Games.Count;
            const int numcells = 3;

            string widthPercent = (100 / numcells) + "%";
            const string heightPercent = "50px";

            for (int j = 0; j < numrows; j++)
            {
                TableRow r = new TableRow();
                for (int i = 0; i < numcells; i++)
                {
                    TableCell c = new TableCell
                    {
                        Width = new Unit(widthPercent),
                        Height = new Unit(heightPercent),
                        ID = "c" + i + "_" + j
                    };

                    if (i == 0)
                    {
                        Label l = new Label
                        {
                            Text = "picture",
                            CssClass = "GamePictureDefault"
                        };

                        c.Controls.Add(l);
                    }
                    if (i == 1)
                    {
                        LinkButton l = new LinkButton
                        {
                            Text = _admin.Games[j].Naam,
                            CssClass = "GameNaamDefault"
                        };

                        l.Click += Naam_Click;

                        c.Controls.Add(l);
                    }
                    if (i == 2)
                    {
                        Label l = new Label
                        {
                            Text = _admin.Games[j].Prijs.ToString("C"),
                            CssClass = "GamesPrijsDefault"
                        };

                        c.Controls.Add(l);
                    }

                    TableCells.Add(c);

                    r.Cells.Add(c);
                }
                GameTable.Rows.Add(r);
            }
        }

        /// <summary>
        /// doorschakelen naar de juiste pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Naam_Click(object sender, EventArgs e)
        {
            LinkButton l = (LinkButton) sender;
            string naam = l.Text;
            HttpContext.Current.Response.Redirect("/Content Pages/GamePage.aspx?naam=" + naam);
        }
    }
}