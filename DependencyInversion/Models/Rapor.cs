using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion.Models
{
    public class Rapor
    {
        public void Gonder()
        {

          //  IGonderici _gonderici;

            //public Rapor (IGonderici gonderici)
           // {
             //   _gonderici = gonderici;
           // }
            //MailGonderici mailGonderici = new MailGonderici();
            //mailGonderici.Gonder();

         //   WhatsappMesajGonderici modernMailGonderici = new WhatsappMesajGonderici();

           // modernMailGonderici.Gonder();


           
        }
    }


    public interface IGonderici
    {
        string Gonder();
    }

    public class MailGonderici:IGonderici
    {
        public string Gonder()
        {
            return "mail";
        }
    }

    public class WhatsappMesajGonderici:IGonderici
    {
        public string Gonder()
        {
            return "wp";
        }
    }

    public class SmsGonderici : IGonderici
    {
        public string Gonder()
        {
            return "sms";
        }
    }
}
