using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VincentsShop.WASM.Shared.Controllers
{
    interface IDolibarrService
    {
        public HttpClient Client { get; }
    }
}
