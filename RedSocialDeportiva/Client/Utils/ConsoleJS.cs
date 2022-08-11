using Microsoft.JSInterop;

namespace RedSocialDeportiva.Client.Utils.ConsoleJS
{
    public class ConsoleJS
    {

        private IJSRuntime _js { get; }
        public ConsoleJS(IJSRuntime jS)
        {
            this._js = jS ?? throw new ArgumentNullException(nameof(jS));
        }

        public async void log(string message, object data)
        {
            await _js.InvokeVoidAsync("console.log", message, data);
        }

    }
}