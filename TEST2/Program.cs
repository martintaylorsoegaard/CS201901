using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //System.Net.WebClient wc = new System.Net.WebClient();
            //byte[] raw = wc.DownloadData("https://cskursus.cronberg.dk/");

            //string webData = System.Text.Encoding.UTF8.GetString(raw);
            //Console.WriteLine(webData);

            string formUrl = @"https://cskursus.cronberg.dk/login?ReturnUrl=%2f"; // NOTE: This is the URL the form POSTs to, not the URL of the form (you can find this in the "action" attribute of the HTML's form tag
            //Console.WriteLine(formUrl);
            string formParams = string.Format("email={0}&password={1}", "!!!!!!!!", "!!!!!!!!!!!!");
            Console.WriteLine(formParams);

            string cookieHeader;
            WebRequest req = WebRequest.Create(formUrl);
            req.ContentType = "application/x-www-form-urlencoded";
            req.Method = "POST";
            byte[] bytes = Encoding.ASCII.GetBytes(formParams);
            req.ContentLength = bytes.Length;
            using (Stream os = req.GetRequestStream())
            {
                os.Write(bytes, 0, bytes.Length);
            }
            WebResponse resp = req.GetResponse();
            cookieHeader = resp.Headers["Set-cookie"];

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
