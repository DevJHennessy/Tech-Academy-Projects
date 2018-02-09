using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_ASP_40
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //When you're using library classes, you want to use to the right name
            //for where to get the class.

            //Visual Studio doesn't know where the class StringBuilder is, it's not specific.
            //StringBuilder sb = new StringBuilder();

            //If you use the full namespace, Visual Studio now knows exactly where to find 
            //the class. It knows exactly which class you mean. This shows how important
            //namespaces are.
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            //Namespaces contain other namespaces. The System namespace contains the text
            //namespace.

            //There are shortcuts for finding the class that you are looking for.
            //One way is to traverse the intellisense, typing in system, and the next
            //namespace until you find the class, but typically you know the class but not
            //the namespace it is in. That's what using directives are for.

            //When you at first type this in, it will show up with red squiggly, and if
            //you use ctrl+i you can view the options to might fix it, including adding the
            //using System.Text.
            //StringBuilder sb = new StringBuilder();

            //Once in a while you run into an error about ambiguity, where two using statements
            //have a class with that name in it. In that case, you'll have to use the entire
            //namespace to get the code working.


        }
    }
}