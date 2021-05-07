using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace EndToEndTest.Utils
{
    public static class FileUtils
    {
        public async static Task SaveAs(IJSRuntime js, string filename, byte[] data)
        {
            await js.InvokeAsync<object>(
                "saveAsFile/methods.FileSaveAs",
                filename,
                Convert.ToBase64String(data));
        }
    }
}
