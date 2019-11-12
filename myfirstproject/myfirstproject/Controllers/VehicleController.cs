using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myfirstproject.Models;

namespace myfirstproject.Controllers
{           
    public class VehicleController : Controller
    {
        // GET: Vehicle
        public ActionResult ToShow()
        {
            var vehicle1 = new vehicle() { VehicleType = "car" , Id =01};

            var categoryname = new List<vehicle>
            //var Listofvehicles = new List<vehicle>
            //{
            //    new vehicle{ VehicleType ="Bike"},
            //    new vehicle{ VehicleType="Truck"}
            //};
            return View();
        }

        public ActionResult Edit(int id)
        {
            return Content("id"+ id);
        }

        //CAN HAVE parameters

        public ActionResult Index(int? noofWheels , string Brand)
        {
             if(!noofWheels.HasValue)
            {
                noofWheels = 4;
            }
            if (String.IsNullOrWhiteSpace(Brand))
                Brand = "Audi";
            return Content(String.Format("NoofWheesl : {0} And Brand Name : {1}", noofWheels ,Brand));
        }
        [Route("vehicle/launchdate/{year}/{month:range(1,12)}")]
        //attribute route is powerfull
        public ActionResult Bylaunchdate( int year , int month)
        {
            return Content(year  + "/" + month );

        }
    }
}