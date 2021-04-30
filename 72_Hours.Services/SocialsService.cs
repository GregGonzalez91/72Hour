using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_Hours.Services
{
    class SocialsService
    {

        //POST METHODS

        //Create Post
        public bool CreatePost(PostCreate model)
        {
            var entity = new Post()
            {
                OwnerId = _userId,
                Title = model.Title,
                Content = model.Content,
                CreatedUtc = DateTimeOffset.Now
            };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Notes.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Get All Posts
        public IEnumerable<NoteListItem> GetAllPosts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Notes
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new NoteListItem
                        {
                            NotedID = e.NoteId,
                            Title = e.Title,
                            CreatedUtc = e.CreatedUtc
                        }
                    );

                return query.ToArray();

            }
        }

        //COMMENT METHODS
        // Create Comment on Post (using Foregn Key Relationship) 

        // Get comment by Post Id 

        //REPLY METHODS
        //Create a reply toa comment using a foreign key relationship

        // Get Replies By Commend Id 


        // LIKE METHODS 
        // Create a Like on a post using a foreign key relationship 

        // Get Likes by Post Id 


    }
}
