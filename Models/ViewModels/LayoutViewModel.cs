using GoogleC29CrudApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleC29CrudApp.Models
{
    public class LayoutViewModel : BaseController
    {
        public bool IsLoggedIn { get; set; }
    }
}