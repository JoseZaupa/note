using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Note.Models
{
    class About
    {
        public string Title => AppInfo.Name;
		public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "Este aplicativo é escrito em XML e C# com .Net Maui! - Lide com isso";
	}
}
