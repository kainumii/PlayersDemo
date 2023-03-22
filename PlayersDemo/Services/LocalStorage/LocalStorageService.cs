using Microsoft.JSInterop;
using System.Text.Json;

namespace PlayersDemo.Services.LocalStorage
{
    public class LocalStorageService : ILocalStorageService
    {
        private IJSRuntime runtime;

        public LocalStorageService(IJSRuntime jsRuntime)
        {
            runtime = jsRuntime;
        }

        public async Task<T> GetItemAsync<T>(string key)
        {
            var json = await runtime.InvokeAsync<string>("localStorage.getItem", key);

            if (string.IsNullOrEmpty(json))
            {
                return default;
            }
            else
            {
                return JsonSerializer.Deserialize<T>(json);
            }
        }

        public async Task SetItemAsync<T>(string key, T item)
        {
            // localStorage can only store string keyvaluepairs
            // --> item has to be string
            await runtime.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(item));
        }
    }
}
