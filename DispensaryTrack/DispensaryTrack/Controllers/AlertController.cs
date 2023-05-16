using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DispensaryTrack.Controllers
{
    public class AlertController : ApiController
    {
        [HttpGet]
        [Route("api/expiredmedicinesalert")]
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
        [Route("api/expiredmedicinesalert")]
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
