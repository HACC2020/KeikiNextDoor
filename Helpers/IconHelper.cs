using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using System.Net.Http;

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;

namespace OhanaSupport.Helpers {
    public class IconHelper {
        private readonly string BASE_URL;
        private readonly HttpClient Http;
        private Dictionary<string, string> Icons = null;


        public IconHelper(IConfiguration Configuration, IHttpClientFactory httpClientFactory) {
            this.Http = httpClientFactory.CreateClient();
            var base_addr = Configuration["BaseAddress"];
            BASE_URL = $"{base_addr}/icons";
            Icons = new Dictionary<string, string>();
            LoadIcons();
        }

        public async Task<MarkupString> GetIconAsync(string name) {
            string icon;
            this.Icons.TryGetValue(name, out icon);
            return (icon == null) ? new MarkupString() : new MarkupString(await this.Http.GetStringAsync(icon));
        }

        public async Task<MarkupString> GetIconAsync(string name, string css) {
            string icon;
            this.Icons.TryGetValue(name, out icon);
            return (icon == null) ? new MarkupString() : new MarkupString((await this.Http.GetStringAsync(icon)).Insert(5, $"class=\"{css}\" "));
        }

        private void LoadIcons() {
            LoadHeroicons();
        }

        private void LoadHeroicons() {
            const string HEROICONS = "heroicons";
            this.Icons["Menu"] = $"{BASE_URL}/{HEROICONS}/menu.svg";
        }
    }
}
/*
@inject Microsoft.AspNetCore.Components.IUriHelper UriHelper

<p> @UriHelper.GetBaseUri()</p>
*/ 