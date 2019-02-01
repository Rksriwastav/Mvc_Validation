using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_WebApiValidation.Models;

namespace WebApplication_WebApiValidation.Controllers
{
    public class UserValidationController : ApiController
    {
        public HttpResponseMessage PostData(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
        }
    }
}
