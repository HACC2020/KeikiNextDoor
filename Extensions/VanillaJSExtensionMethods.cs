using System.Threading.Tasks;

using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace OhanaSupport.Extensions {
    public static class VanillaJSExtensionMethods {
        public static ValueTask<object> FocusElement(this IJSRuntime js, ElementReference element) => js.InvokeAsync<object>(
            "focus",
            element
        );

        public static ValueTask<object> SetItemLocalStorage(this IJSRuntime js, string key, string content) => js.InvokeAsync<object>(
            "setItem",
            key, content
        );

        public static ValueTask<string> GetItemLocalStorage(this IJSRuntime js, string key) => js.InvokeAsync<string>(
            "getItem",
            key
        );

        public static ValueTask<object> RemoveItemLocalStorage(this IJSRuntime js, string key) => js.InvokeAsync<object>(
            "removeItem",
            key
        );

        public static ValueTask<object> ClearItemsLocalStorage(this IJSRuntime js, string key) => js.InvokeAsync<object>(
            "clear",
            key
        );
    }
}
