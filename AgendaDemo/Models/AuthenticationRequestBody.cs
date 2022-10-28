using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaDemo.Models
{
    public class AuthenticationRequestBody
    {
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
