using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.Posts.Any())
            {
                var Posts = new List<Post>
                {
                    new Post {
                        Title = "First post",
                        Body = "First post body here",
                        Date = DateTime.Now.AddDays(-10)
                        },
                    new Post {
                        Title = "Second post",
                        Body = "Second post body.....good blog stuff",
                        Date = DateTime.Now.AddDays(-7)
                        },
                    new Post {
                        Title = "Third post",
                        Body = "Third post body...seems to be lacking content",
                        Date = DateTime.Now.AddDays(-4)
                        }
                };

                context.Posts.AddRange(Posts);
                context.SaveChanges();
            }
        }
    }
}
