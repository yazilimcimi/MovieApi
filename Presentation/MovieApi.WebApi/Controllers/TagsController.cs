using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPatterns.Comands.TagCommands;
using MovieApi.Application.Features.MediatorDesignPatterns.Queries.TagQueries;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly IMediator _meditor;

        public TagsController(IMediator mediator)
        {
            _meditor = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var values = await _meditor.Send(new GetTagQuery());
            return Ok(values);
        }
        [HttpGet("GetTagById")]
        public async Task<IActionResult> GetTagById(int id)
        {
            var value = await _meditor.Send(new GetTagByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(CreateTagCommand request)
        {
            await _meditor.Send(request);
            return Ok("Ekleme işlemi başarılı oldu");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteTag(int id)
        {
            await _meditor.Send(new RemoveTagCommand(id));
            return Ok("Güncelleme işlemi başarılı oldu");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTag(UpdateTagCommand request)
        {
            await _meditor.Send(request);
            return Ok("Güncelleme işlemi başarılı oldu");
        }
          

    }
}
