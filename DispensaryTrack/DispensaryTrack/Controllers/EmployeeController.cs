//shadril238
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
    [Logged]
    [EnableCors("*","*","*")]
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]
        public HttpResponseMessage Employees()
        {
            try
            {
                var data = EmployeeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/employees/{email}")]
        public HttpResponseMessage Employee(string email)
        {
            try
            {
                var data = EmployeeService.Get(email);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/employees/delete/{email}")]
        public HttpResponseMessage DeleteEmployee(string email)
        {
            try
            {
                var data = EmployeeService.Delete(email);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/employees/insert")]
        public HttpResponseMessage InsertEmployee(EmployeeDTO employee)
        {
            try
            {
                var data = EmployeeService.Create(employee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/employees/update")]
        public HttpResponseMessage UpdateEmployee(EmployeeDTO employee)
        {
            try
            {
                var data = EmployeeService.Update(employee);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
