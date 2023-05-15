using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DispensaryTrack.Controllers
{
    [EnableCors("*","*","*")]
    public class PurchaseReportController : ApiController
    {
        [HttpGet, Route("/api/totalpurchasesperday")]
        public HttpResponseMessage GetPerDayTotalPurchases()
        {
            try
            {
                var data = PurchaseReportService.GetPerDayTotalPurchases();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet, Route("/api/totalpurchaseperday")]
        public HttpResponseMessage GetPerDayTotalPurchase()
        {
            try
            {
                var data = PurchaseReportService.GetPerDayTotalPurchase();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet, Route("/api/totalpurchasepermonth")]
        public HttpResponseMessage GetPerMonthTotalPurchase()
        {
            try
            {
                var data = PurchaseReportService.GetPerMonthTotalPurchase();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}