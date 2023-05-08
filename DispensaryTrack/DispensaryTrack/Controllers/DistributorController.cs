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
    public class DistributorController : ApiController
    {
        [HttpGet]
        [Route("api/distributors")]
        public HttpResponseMessage Distributors()
        {
            try
            {
                var data = DistributorCompanyService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/distributors/{id}")]
        public HttpResponseMessage Distributor(int id)
        {
            try
            {
                var data = DistributorCompanyService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/distributors/delete/{id}")]
        public HttpResponseMessage DeleteDistributor(int id)
        {
            try
            {
                var data = DistributorCompanyService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/distributors/insert")]
        public HttpResponseMessage InsertDistributor(DistributorCompanyDTO distributor)
        {
            try
            {
                var data = DistributorCompanyService.Create(distributor);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/distributors/update")]
        public HttpResponseMessage UpdateDistributor(DistributorCompanyDTO distributor)
        {
            try
            {
                var data = DistributorCompanyService.Update(distributor);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
