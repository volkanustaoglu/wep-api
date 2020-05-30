using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MailGonder.Models
{
    public static class Veritabani
    {
        private static Dictionary<string, DavetiyeModel> _liste;

        static Veritabani()
        {
            _liste = new Dictionary<string, DavetiyeModel>();

            _liste.Add("Ayse", new DavetiyeModel
            {
                Ad = "Ayse",
                Email = "ayse@gmail.com",
                KatilacakMi = true
            });

            _liste.Add("Mehmet", new DavetiyeModel
            {
                Ad = "Mehmet",
                Email = "mehmet@gmail.com",
                KatilacakMi = false
            });

            _liste.Add("Fulya", new DavetiyeModel
            {
                Ad = "Fulya",
                Email = "fulya@gmail.com",
                KatilacakMi = true
            });

        }

        internal static void Add(object model)
        {
            throw new NotImplementedException();
        }

        public static void Add(DavetiyeModel model)
        {
            string key = model.Ad.ToLower();
            if (_liste.ContainsKey(key))
            {
                _liste[key] = model;
            }
            else
            {
                _liste.Add(key, model);
            }
        }

        public static IEnumerable<DavetiyeModel> Liste
        {
            get { return _liste.Values; }
        }
    }
}