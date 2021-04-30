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
            var cService = CreateCommentService();
            var comments = cService.GetComments();
            return Ok(comments)
        }
        public IHttpActionResult Post(CommentCreate comment)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var cService = CreateCommentService();
            return InternalServerErrror();

            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            var cService = CreateCategoryService();
            var comment = cService.GetComment.ById(id);
       
        }
    }