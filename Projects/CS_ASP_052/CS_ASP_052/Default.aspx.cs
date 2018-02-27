using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_052
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  https://en.wikipedia.org/wiki/Universally_unique_identifier

            //How to create a new GUID, stored at type Guid is shown below:
           // var myGuid = Guid.NewGuid();

            //Since the GUID is of type Guid, you have to ToString() it to display
            //in the result label as a string value.
            //resultLabel.Text = myGuid.ToString();

            //If you retrieve a string value from a database that doesn't have a
            //notion of GUIDS, you can do something like this:

            //Parsing a string into a Guid
            //var myOtherGuid = Guid.Parse("bd2befae-b8df-4c33-9ee6-21079f80135f");

            //Parsing a string into a Guid with TryParse in case the number cannot
            //be parsed out:

            Guid myOtherGuid;
            if (Guid.TryParse("bd2befae-b8df-4c33-9ee6-21079f80135f", out myOtherGuid))
            {
                resultLabel.Text = myOtherGuid.ToString();
            }


        }
    }
}