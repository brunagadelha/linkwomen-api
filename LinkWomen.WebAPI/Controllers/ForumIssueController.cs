using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LinkWomen.Domain.DTOs;
using LinkWomen.Domain.Models;
using LinkWomen.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LinkWomen.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumIssueController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IForumIssueService _forumIssueService;
        private readonly IForumCommentService _forumCommentService;
        private readonly IUserService _userService;

        public ForumIssueController(IMapper mapper, 
                                    IForumIssueService forumIssueService, 
                                    IForumCommentService forumCommentService, 
                                    IUserService userService)
        {
            _mapper = mapper; 
            _forumIssueService = forumIssueService;
            _forumCommentService = forumCommentService;
            _userService = userService; 
        }

        /// <summary>
        /// Get a issue
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("{id}")]
        public ActionResult<ForumIssueDTO> Get(int id)
        {
            var issue = _forumIssueService.GetById(id);

            if (issue == null)
                return NotFound();

            return _mapper.Map<ForumIssueDTO>(issue);
        }

        /// <summary>
        /// Get all issues
        /// </summary>
        /// <param name="categoryId"></param>
        /// <param name="isPinned"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("All")]
        [Authorize]
        public IEnumerable<ForumIssueDTO> GetAll(int categoryId = 0, bool isPinned = false)
        {
            var issues = _forumIssueService.GetAll(categoryId, isPinned).ToList();

            return _mapper.Map<IEnumerable<ForumIssueDTO>>(issues);
        }

        /// <summary>
        /// Create an issue 
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize]
        public ActionResult Post([FromBody] ForumIssueCreateDTO dto)
        {
            var user = _userService.GetByUsername(User.Identity.Name);
            if (user == null)
                return StatusCode(401, "usuário não autenticado");

            var issue = _mapper.Map<ForumIssue>(dto);
            issue.ForumType = Domain.Enumerators.ForumTypeEnum.Public; 
            issue.UserId = user.Id;

            _forumIssueService.Add(issue);

            return NoContent(); 
        }

        /// <summary>
        /// Update an issue
        /// </summary>
        /// <param name="id"></param>
        /// <param name="dto"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("{id}")]
        [Authorize]
        public ActionResult Put(int id, [FromBody] ForumIssueCreateDTO dto)
        {
            var issue = _forumIssueService.GetById(id);

            if (issue == null)
                return NotFound();

            issue.CategoryId = dto.CategoryId;
            issue.Content = dto.Content;
            issue.Title = dto.Title;

            return NoContent(); 
        }

        /// <summary>
        /// Delete an issue
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Authorize]
        public ActionResult Delete(int id)
        {
            var issue = _forumIssueService.GetById(id);

            if (issue == null)
                return NotFound();

            _forumIssueService.Delete(issue);

            return NoContent(); 

        }

        #region Comments

        /// <summary>
        /// Create a comment for an issue 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="comment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("{id}/Comment")]
        [Authorize]
        public ActionResult PostComment(int id, [FromBody] string comment)
        {
            var user = _userService.GetByUsername(User.Identity.Name);
            if (user == null)
                return StatusCode(401, "usuário não autenticado");

            var issue = _forumIssueService.GetById(id);
            if (issue == null)
                return NotFound("item não encontrado");

            var entity = new ForumComment()
            {
                Comment = comment,
                UserId = user.Id, 
                ForumIssueId = id
            }; 

            _forumCommentService.Add(entity);

            return NoContent();
        }

        /// <summary>
        /// Update a comment
        /// </summary>
        /// <param name="id"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("Comment/{id}")]
        [Authorize]
        public ActionResult PutComment(int id, [FromBody] string text)
        {
            var entity = _forumCommentService.GetById(id);
            if (entity == null)
                return NotFound("comentário não encontrado");

            entity.Comment = text; 

            _forumCommentService.Update(entity);
            return NoContent();
        }

        /// <summary>
        /// Delete a comment
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("Comment/{id}")]
        [Authorize]
        public ActionResult DeleteComment(int id)
        {
            var comment = _forumCommentService.GetById(id);
            if (comment == null)
                return NotFound("comentário não encontrado");

            _forumCommentService.Delete(comment);

            return NoContent();
        }

        #endregion Comments
    }
}
