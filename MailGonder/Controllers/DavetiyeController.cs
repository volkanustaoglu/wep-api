using MailGonder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MailGonder.Controllers
{
    public class DavetiyeController : ApiController
    {
        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilacakMi == true);
        }
        [HttpGet]
        public IEnumerable<DavetiyeModel> Katilamayanlar()
        {
            return Veritabani.Liste.Where(i => i.KatilacakMi == false);
        }
        [HttpPost]
        public void Ekle(DavetiyeModel model)
        {
            if (ModelState.IsValid)
            {
                Veritabani.Add(model);
            }
        }
    }
}
