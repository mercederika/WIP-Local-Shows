using GoogleC29CrudApp.Models.Requests;
using GoogleC29CrudApp.Models.Response;
using GoogleC29CrudApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace GoogleC29CrudApp.Controllers.Api
{
    [RoutePrefix("api/shows")]
    public class ShowsApiController :ApiController
    {
        [Route(), HttpPost]
        public HttpResponseMessage CreateShow(ShowCreateRequest model)
        {
            ItemResponse<int> response = new ItemResponse<int>();
            response.Item = ShowService.CreateShow(model);
            return Request.CreateResponse(HttpStatusCode.OK, response);
        }
    }
}