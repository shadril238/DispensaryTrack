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
    public class PurchaseMedicineController : ApiController
    {
        [HttpGet]
        [Route("api/purchasemedicines")]
        public HttpResponseMessage PurchaseMedicines()
        {
            try
            {
                var data = PurchaseMedicineService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/purchasemedicines/{id}")]
        public HttpResponseMessage PurchaseMedicine(int id)
        {
            try
            {
                var data = PurchaseMedicineService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/purchasemedicines/delete/{id}")]
        public HttpResponseMessage DeletePurchaseMedicine(int id)
        {
            try
            {
                var data = PurchaseMedicineService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/purchasemedicines/insert")]
        public HttpResponseMessage InsertPurchaseMedicine(PurchaseMedicineDTO purchasemedicine)
        {
            try
            {
                var data = PurchaseMedicineService.Create(purchasemedicine);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/purchasemedicines/update")]
        public HttpResponseMessage UpdatePurchaseMedicine(PurchaseMedicineDTO purchasemedicine)
        {
            try
            {
                var data = PurchaseMedicineService.Update(purchasemedicine);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
