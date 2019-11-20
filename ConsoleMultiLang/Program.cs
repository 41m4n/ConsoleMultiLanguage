using ConsoleMultiLang.Resource;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleMultiLang
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cul;

            //System.Resources.ResourceManager mgr = new
            // System.Resources.ResourceManager("ConsoleMultiLang.Resource.en",
            //System.Reflection.Assembly.GetExecutingAssembly());

            //Thread.CurrentThread.CurrentCulture = new CultureInfo("en");
            //Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");

            cul = CultureInfo.CreateSpecificCulture("ms");
            //int i = 1;

            //while (i <= 2) {

            //    switch (i) {
            //        case 1:
            //            var lang = new en();
            //            break;
            //        case 2:
            //            var lang2 = new rus();
            //            break;
            //        default:
            //            break;
            //    }

            //}


            //Console.WriteLine(en.on);

            //Console.WriteLine(rus.on);

            //Console.WriteLine(mgr.GetString("on"));
            ResourceManager rm = new ResourceManager("ConsoleMultiLang.Resource.LangResource",
                Assembly.GetExecutingAssembly());
            String strWebsite = rm.GetString("on", cul);

            Console.WriteLine(strWebsite);

            String strName = rm.GetString("off", cul);

            Console.WriteLine(strName);

            ResourceManager MyResourceClass = new ResourceManager(typeof(ConsoleMultiLang.Resource.LangResource));

            ResourceSet resourceSet = MyResourceClass.GetResourceSet(CultureInfo.CurrentCulture, true, true);
            foreach (DictionaryEntry entry in resourceSet)
            {
                string resourceKey = entry.Key.ToString();
                string resource = entry.Value.ToString();
                Console.WriteLine(resource);
            }

            Console.ReadLine();

            //string test = res_man.GetString("on", cul);           

            //Console.WriteLine(test);

            //Console.ReadLine();
        }
    }
}
