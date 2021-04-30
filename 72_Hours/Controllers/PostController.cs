using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace _72_Hours.Controllers
{
    [Authorize]
    public class SocialController : Controller
    {
        public IHttpActionResult Get()
        {
            var pService = CreateC();
            var posts = pService.GetPosts();
            return Ok(posts);
        }
        public IHttpActionResult Post(PostCreate post)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var pService = CreatePostService();

            if (!pService.CreatePost(post))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            var pService = CreatePostService();
            var post = pService.GetPostById(id);
            return Ok(post);
        }

        public IHttpActionResult Delete(int id)
        {
            var pService = CreatePostService();

            if (!pService.DeleteCategory(id))
                return InternalServerError();

            return Ok();
        }
        private PostService CreatePostService()
        {
            var postService = new PostService();
            return postService;
        }
    }
}
