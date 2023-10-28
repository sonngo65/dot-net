using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using thicuoiky.Models;

namespace thicuoiky.Controllers
{
    public class DanhMucController : ApiController
    {
        CSDLTestEntities1 db = new CSDLTestEntities1();
        [HttpGet]
        public List<DanhMuc> listAllDanhMuc()
        {
            return db.DanhMucs.ToList();

        }
    }
}
