using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace _72_Hours.Controllers
{
    [Authorize]
    public class CommentController : ApiController
    {
        public IHttpActionResult Get()
        {
            var cservice = CreateCommentService();
            var 
        }
    }