//shadril238
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DispensaryTrack.Controllers
{
    [EnableCors("*", "*", "*")]

    public class RackController : ApiController
    {
        [HttpGet]
        [Route("api/racks")]
        public HttpResponseMessage Racks()
        {
            try
            {
                var data = RackService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/racks/{id}")]
        public HttpResponseMessage Rack(int id)
        {
            try
            {
                var data = RackService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/racks/delete/{id}")]
        public HttpResponseMessage DeleteRack(int id)
        {
            try
            {
                var data = RackService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/racks/insert")]
        public HttpResponseMessage InsertRack(RackDTO rack)
        {
            try
            {
                var data = RackService.Create(rack);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/racks/update")]
        public HttpResponseMessage UpdateRack(RackDTO rack)
        {
            try
            {
                var data = RackService.Update(rack);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
