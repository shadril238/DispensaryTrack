////shadril238
using BLL.DTOs;
using BLL.Services;
using DispensaryTrack.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DispensaryTrack.Controllers
{
    [AdminAccess]
    [EnableCors("*","*","*")]
    public class CustomerController : ApiController
    {
        
        [HttpGet]
        [Route("api/customers")]
        public HttpResponseMessage Customers()
        {
            try
            {
                var data = CustomerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/customers/{id}")]
        public HttpResponseMessage Customer(int id)
        {
            try
            {
                var data = CustomerService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/customers/delete/{id}")]
        public HttpResponseMessage DeleteCustomer(int id)
        {
            try
            {
                var data = CustomerService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/customers/insert")]
        public HttpResponseMessage InsertEmployee(CustomerDTO customer)
        {
            try
            {
                var data = CustomerService.Create(customer);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/customers/update")]
        public HttpResponseMessage UpdateCustomer(CustomerDTO customer)
        {
            try
            {
                var data = CustomerService.Update(customer);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
