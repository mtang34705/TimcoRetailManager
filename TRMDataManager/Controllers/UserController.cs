using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Internal.Models;

namespace TRMDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : System.Web.Http.ApiController
    {
        // GET: User/Details/5
        public List<UserModel> GetById()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();
            UserData data = new UserData();

            return data.GetUserById(userId);
        }

       
    }
}
