using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser4
{
    internal class AppSettings
    {
        public int AppId;
        private static AppSettings o = null;

        private AppSettings()
        {}

        public static AppSettings HentAppSettings()
        {
            if (o == null)
                o = new AppSettings();
            return o;
        }
  
    }
}
