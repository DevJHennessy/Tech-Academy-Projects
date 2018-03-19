using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_062_GridViewButtonCommand
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cars = new List<Car>()
            {
                new Car { CarId = Guid.NewGuid(), Make = "BMW", Model = "528i", Year = 2010 },
                new Car { CarId = Guid.NewGuid(), Make = "Toyota", Model = "4Runner", Year = 2005},
                new Car { CarId = Guid.NewGuid(), Make = "Hyunda", Model = "Elantra", Year = 2013 }
            };

            GridView1.DataSource = cars;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //e.CommandArgument //The row index that was selected starting at 0.

            //The to Convert ToInt32 will convert the index(the row) to an integer:
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = GridView1.Rows[index];

            //This is a bit risky, take great caution.
            //The code below will pull the cell of the row in order from left to right
            //and if you change the order, say swap Make and Model position, then the code
            //will not work.
            var make = row.Cells[1].Text;
            var model = row.Cells[2].Text;
            var value = row.Cells[4].Text;

            //You would probably want to convert it to its original type:
            var cardId = Guid.Parse(value);

            resultLabel.Text = String.Format("{0} {1} {2}",
                make,
                model,
                cardId);


        }
    }

    public class Car
    {
        public Guid CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}