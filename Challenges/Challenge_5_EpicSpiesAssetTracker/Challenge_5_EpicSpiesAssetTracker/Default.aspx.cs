using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Challenge_5_EpicSpiesAssetTracker
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                double[] rigged = new double[0];
                ViewState.Add("Rigged", rigged);
                double[] subterfuge = new double[0];
                ViewState.Add("Subterfuge", subterfuge);
                ViewState.Add("AssetName", "");
                

            }
        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double[] rigged = (double[])ViewState["Rigged"];
            Array.Resize(ref rigged, rigged.Length + 1);
            int newNumber = rigged.GetUpperBound(0);
            rigged[newNumber] = double.Parse(riggedTextBox.Text);
            ViewState["Rigged"] = rigged;

            double[] subterfuge = (double[])ViewState["Subterfuge"];
            Array.Resize(ref subterfuge, subterfuge.Length + 1);
            int newerNumber = subterfuge.GetUpperBound(0);
            subterfuge[newerNumber] = double.Parse(subterfugeTextBox.Text);
            ViewState["Subterfuge"] = subterfuge;

            string name = ViewState["AssetName"].ToString();
            name = nameTextBox.Text;
            ViewState["AssetName"] = name;
            resultLabel.Text = String.Format("Total Elections Rigged: {0}" +
                "<br>Average Acts of Subterfuge per Asset: {1:N2}" +
                "<br>Last Asset you Added: {2}", rigged.Sum(), subterfuge.Average(), name);

            nameTextBox.Text = "";
            riggedTextBox.Text = "";
            subterfugeTextBox.Text = "";


            
        }
    }
}