using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace ControllerExtensibility.Models
{
    public class RemoteService
    {
        public string GetRemoteData()
        {
            Thread.Sleep(2000);
            return "Hello from other side, remote service";
        }

        public async Task<string> GetRemoteDataAsync()
        {
            await Task.Delay(2000);
            return "Hello from other side, remote service async call";
        }
    }
}