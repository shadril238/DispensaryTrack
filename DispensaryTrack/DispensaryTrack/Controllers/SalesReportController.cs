//shadril238
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
    [EnableCors("*","*","*")]
    public class SalesReportController : ApiController
    {
        [HttpGet, Route("api/totalsalesperday")]
        public HttpResponseMessage GetPerDayTotalSales()
        {
            try
            {
                var data = SalesReportService.GetPerDayTotalSales();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet, Route("api/totalsaleperday")]
        public HttpResponseMessage GetPerDayTotalSale()
        {
            try
            {
                var data = SalesReportService.GetPerDayTotalSale();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
        [HttpGet, Route("api/totalsalepermonth")]
        public HttpResponseMessage GetPerMonthTotalSale()
        {
            try
            {
                var data = SalesReportService.GetPerMonthTotalSale();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }

        }
    }
}
