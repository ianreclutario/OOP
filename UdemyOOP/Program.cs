using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FifthGenKpop;
namespace UdemyOOP
{
    class Program
    {
   

        static void Main(string[] args)
        {
            KpopGroup lpnr = new KpopGroup("Hirai Momo","Park Jihyo");

            lpnr.mainVocalist = "Park Jihyo";
            lpnr.leadVocalist = "Im Nayeon";



            lpnr.visual = "Shin Ryujin";
            lpnr.mainVocalist = "Ian Rex Clutario";
            lpnr.leadVocalist = "Myoui Mina";
            lpnr.mainDancer = "Hirai Momo";
            lpnr.leadDancer = "Park Jihyo";
            lpnr.rapper = "Quejano Charles";
        }
    }
}
