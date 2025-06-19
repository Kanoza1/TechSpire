using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TechSpire.Application.Services;

namespace TechSpire.APi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TopicController : ControllerBase
{
    private readonly ITopicService _topicService;

    public TopicController(ITopicService topicService)
    {
        _topicService = topicService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllTopics()
    {
        var result = await _topicService.GetAllTopicsAsync();
        if (!result.IsSuccess)
            return NotFound(result);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetTopicById(int id)
    {
        var result = await _topicService.GetTopicByIdAsync(id);
        if (!result.IsSuccess)
            return NotFound(result);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> CreateTopic([FromBody] string name)
    {
        var result = await _topicService.CreateTopicAsync(name);
        if (!result.IsSuccess)
            return BadRequest(result);
        return Ok(result);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateTopic(int id, [FromBody] string name)
    {
        var result = await _topicService.UpdateTopicAsync(id, name);
        if (!result.IsSuccess)
            return BadRequest(result);
        return Ok(result);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTopic(int id)
    {
        var result = await _topicService.DeleteTopicAsync(id);
        if (!result.IsSuccess)
            return NotFound(result);
        return Ok(result);
    }
} 