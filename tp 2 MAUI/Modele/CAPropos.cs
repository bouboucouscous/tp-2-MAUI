using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_2_MAUI.Models
{
    class CAPropos
    {
        public string Title => "Notes 3iL - " + AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://www.3il-ingenieurs.fr/";
        public string Message => "Application XAML/C# écrite en .NET MAUI.";
    }
}
