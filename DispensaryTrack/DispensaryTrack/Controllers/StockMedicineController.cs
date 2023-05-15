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
    public class StockMedicineController : ApiController
    {
        [HttpGet]
        [Route("api/stocks")]
        public HttpResponseMessage StockMedicines()
        {
            try
            {
                var data = StockMedicineService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/stocks/{id}")]
        public HttpResponseMessage StockMedicine(int id)
        {
            try
            {
                var data = StockMedicineService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/stocks/delete/{id}")]
        public HttpResponseMessage DeleteStockMedicine(int id)
        {
            try
            {
                var data = StockMedicineService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/stocks/insert")]
        public HttpResponseMessage InsertStockMedicine(StockMedicineDTO stockmedicine)
        {
            try
            {
                var data = StockMedicineService.Create(stockmedicine);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/stocks/update")]
        public HttpResponseMessage UpdateStockMedicine(StockMedicineDTO stockmedicine)
        {
            try
            {
                var data = StockMedicineService.Update(stockmedicine);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
