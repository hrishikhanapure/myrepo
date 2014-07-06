using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           // SearlizeJson();
            
        }

        private void SearlizeJson()
        {
            Class1 cls = new Class1()
            {
                Id = 1827,
                Name = "adsfasdf"
            };
            Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(cls));
            //Class2 cls1 = new Class2()
            //{
            //    Id = 1827,
            //    Name = "HRishi",
            //    Salary = 90000
            //};

           // Response.Write(Newtonsoft.Json.JsonConvert.SerializeObject(cls1));
        }
    }
}