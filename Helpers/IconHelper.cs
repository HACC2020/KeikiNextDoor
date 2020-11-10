using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;

using Microsoft.AspNetCore.Components;

namespace OhanaSupport.Helpers {
    public class IconHelper {
        private readonly string ICON_DIRECTORY = "/icons";
        private readonly HttpClient Http;
        private Dictionary<string, MarkupString> Icons = null;


        public IconHelper(IHttpClientFactory httpClientFactory) {
            this.Http = httpClientFactory.CreateClient();
            Icons = new Dictionary<string, MarkupString>();
        }

        //Method to get SVG Icon
        public MarkupString? GetIcon(string name) {
            //does it exist: no return null
            if (!(this.Icons.ContainsKey(name))) return null;
            return this.Icons[name];
        }


        //Method to get SVG and insert class
        public MarkupString? GetIcon(string name, string css) {
            if (!(this.Icons.ContainsKey(name))) return null;
            MarkupString icon = this.Icons[name];
            string svg = icon.Value;
            return new MarkupString(svg.Insert(5, $"class=\"{css}\" "));
        }

        public async Task LoadIcons() {
            //
        }

        //Load certain icons based on directory.
    }
}