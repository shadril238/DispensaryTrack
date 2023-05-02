//shadril238
using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DispensaryTrack.Controllers
{
    public class MedicineController : ApiController
    {
        [HttpGet]
        [Route("api/medicines")]
        public HttpResponseMessage Medicines()
        {
            try
            {
                var data = MedicineService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/medicines/{id}")]
        public HttpResponseMessage Medicine(int id)
        {
            try
            {
                var data = MedicineService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/medicines/delete/{id}")]
        public HttpResponseMessage DeleteMedicine(int id)
        {
            try
            {
                var data = MedicineService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            } 
        }
        [HttpPost]
        [Route("api/medicines/insert")]
        public HttpResponseMessage InsertMedicine(MedicineDTO medicine)
        {
            try
            {
                var data = MedicineService.Create(medicine);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/medicines/update")]
        public HttpResponseMessage UpdateMedicine(MedicineDTO medicine)
        {
            try
            {
                var data = MedicineService.Update(medicine);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
