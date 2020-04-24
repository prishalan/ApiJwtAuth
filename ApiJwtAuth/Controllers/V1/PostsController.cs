using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiJwtAuth.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiJwtAuth.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private List<Post> _posts;

        public PostsController()
        {
            _posts = new List<Post>();
            for (int i = 0; i < 4; i++)
            {
                _posts.Add(new Post{ Id = Guid.NewGuid().ToString() });
            }
        }

        // GET api/v1/posts
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetAll()
        {
            return Ok(_posts);
        }

        // GET api/v1/posts/5
        [HttpGet("{id}")]
        public ActionResult<Post> Get(string id)
        {
            return Ok(_posts.Where(x => x.Id == id).FirstOrDefault());
        }

        [HttpPost]
        public ActionResult Create([FromBody] Post post)
        {
            return Ok();
        }

    }
}
