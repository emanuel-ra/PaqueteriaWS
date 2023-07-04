using PaqueteriaWS.Models.Context;
using PaqueteriaWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PaqueteriaWS.Controllers
{
    [EnableCors(origins: "http://localhost:5173,http://192.168.0.3:8000,http://192.168.0.19:8000", headers: "*", methods: "*")]
    public class SendexController : ApiController
    {
        [HttpGet]
        public Reply Get(string zipcode)
        {
            Reply reply = new Reply();
            reply.message = "Not Found";
            reply.statusCode = 400;

            using (var db = new PaqueteriasEntities())
            {
                var data = (from d in db.Sendex where d.CodigoPostal == zipcode select d).ToList();
                if (data.Count > 0)
                {
                    reply.data = data;
                    reply.message = "Data founded";
                    reply.statusCode = 200;
                }
            }

            return reply;
        }
    }
}
