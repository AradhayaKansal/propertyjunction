using Microsoft.AspNet.Mvc;
using PropertyJunction.Common;
using System;
using System.Collections.Generic;

namespace PropertyJunction.Controllers
{
    public class HomeController : Controller
    {
        #region variables
        readonly string CONST_SITE_URL = "PropertyJunction.co.in";
        #endregion

        #region controllers
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.DDLPropertyType = GetPropertyTypes();
            ViewBag.Title = CONST_SITE_URL;
            return View();
        }
        #endregion

        #region private methods
        /// <summary>
        /// was trying something different. we can remove this
        /// </summary>
        /// <returns></returns>
        private List<Tuple<string, string>> GetPropertyTypes()
        {
            /// Item1 : URL 
            /// Item3 : Display Name
            List<Tuple<string, string>> pTypeList = new List<Tuple<string, string>>();

            foreach (Enum name in Enum.GetValues(typeof(PropertyType)))
            {
                pTypeList.Add(new Tuple<string, string>(ExtensionMethod.GetEnumDescription(name),name.ToString()));
            }
            return pTypeList;
        }
        #endregion
    }
}
