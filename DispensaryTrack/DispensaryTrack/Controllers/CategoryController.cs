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
    public class CategoryController : ApiController
    {
        [HttpGet]
        [Route("api/categories")]
        public HttpResponseMessage Categories()
        {
            try
            {
                var data = CategoryService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/categories/{id}")]
        public HttpResponseMessage Category(int id)
        {
            try
            {
                var data = CategoryService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/categories/delete/{id}")]
        public HttpResponseMessage DeleteCategory(int id)
        {
            try
            {
                var data = CategoryService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/categories/insert")]
        public HttpResponseMessage InsertCategory(CategoryDTO category)
        {
            try
            {
                var data = CategoryService.Create(category);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/categories/update")]
        public HttpResponseMessage UpdateCategory(CategoryDTO category)
        {
            try
            {
                var data = CategoryService.Update(category);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }
    }
}
