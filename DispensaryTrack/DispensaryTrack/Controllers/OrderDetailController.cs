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
    public class OrderDetailController : ApiController
    {
        [HttpGet]
        [Route("api/orderdetails")]
        public HttpResponseMessage OrderDetails()
        {
            try
            {
                var data = OrderDetailService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/orderdetails/{id}")]
        public HttpResponseMessage OrderDetail(int id)
        {
            try
            {
                var data = OrderDetailService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/orderdetails/delete/{id}")]
        public HttpResponseMessage DeleteOrderDetail(int id)
        {
            try
            {
                var data = OrderDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/orderdetails/insert")]
        public HttpResponseMessage InsertOrderDetail(OrderDetailDTO orderdetail)
        {
            try
            {
                var data = OrderDetailService.Create(orderdetail);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/orderdetails/update")]
        public HttpResponseMessage UpdateOrderDetail(OrderDetailDTO orderdetail)
        {
            try
            {
                var data = OrderDetailService.Update(orderdetail);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
