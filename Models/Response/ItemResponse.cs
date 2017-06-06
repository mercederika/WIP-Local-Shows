using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoogleC29CrudApp.Models.Response
{
    public class ItemResponse<T>
    {
        public T Item { get; set; }
    }
}