using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var bindList = carsList();
            Drop.DataSource = bindList;
            Drop.DataTextField = "Cname";
            Drop.DataValueField = "";
            Drop.DataBind();



        }

        public class Cars
        {
            public string name { get; set; }

        }
        public static List<Cars> carList()
        {
            var myList = new List<Cars>();
            myList.Add(new Cars() { name = "Chevrolet" });
            myList.Add(new Cars() { name = "Honda" });
            myList.Add(new Cars() { name = "Nissan" });
            myList.Add(new Cars() { name = "Ford"});
            myList.Add(new Cars() { name = "Fiat" });
            myList.Add(new Cars() { name = "Jeep"});
            myList.Add(new Cars() { name = "Volkswagen" });
            myList.Add(new Cars() { name = "Volvo"});
            myList.Add(new Cars() { name = "Jaguar" });
            myList.Add(new Cars() { name = "Audi" });
            myList.Add(new Cars() { name = "Toyota" });
            myList.Add(new Cars() { name = "Civic" });
            myList.Add(new Cars() { name = "Land rover" });
            myList.Add(new Cars() { name = "Lexus"});
            myList.Add(new Cars() { name = "Porshce"});
            myList.Add(new Cars() { name = "Bugatti" });
            myList.Add(new Cars() { name = "Bentley"});
            myList.Add(new Cars() { name = "Rolls royce"});
            myList.Add(new Cars() { name = "BMW" });
            myList.Add(new Cars() { name = "Tesla"});

            return myList;
        }
        
    }
}