using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechSpire.Application.Services;

namespace TechSpire.APi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TopicController(ITopicService topicService) : ControllerBase
{
    private readonly ITopicService topicService = topicService;

    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetTopic(int id)
    {
        var result = await topicService.GetTopic(id);
        return result.IsSuccess
            ? Ok(result.Value)
            : result.ToProblem();
    }

    [HttpGet("{name:alpha}")]
    public async Task<IActionResult> GetTopicByName(string name)
    {
        var result = await topicService.GetTopicByName(name);
        return result.IsSuccess
            ? Ok(result.Value)
            : result.ToProblem();
    }
}
