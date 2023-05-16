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
    [EnableCors("*", "*", "*")]
    [AdminAccess]
    [ManagerAccess]
    public class AlertController : ApiController
    {
        [HttpGet]
        [Route("api/expiremedicinesalert")]
        public HttpResponseMessage ExpireMedicinesAlert()
        {
            try
            {
                var data = AlertService.ExpireMedicineAlert();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/stockmedicinesalert")]
        public HttpResponseMessage StockMedicinesAlert()
        {
            try
            {
                var data = AlertService.StockMedicineAlert();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
