using API.Errors;
using Microsoft.AspNetCore.Mvc;
using Mscc.GenerativeAI;

namespace TechSpire.APi.Controllers;



[Route("[controller]")]
[ApiController]
public class ChatbotController : ControllerBase
{
    private const string EmptyMessageError = "الرسالة لا يمكن أن تكون فارغة";
    private const string FailedGenerationError = "فشل في توليد النص";

    private readonly GoogleAI _googleAI;
    private readonly GenerativeModel _model;

    public ChatbotController()
    {
        const string apiKey = "AIzaSyCPNH_f5luv4laP1D3LKmRfk4qm-hXzgOs"; // ضع مفتاح API هنا
        _googleAI = new GoogleAI(apiKey: apiKey);
        _model = _googleAI.GenerativeModel(model: Model.Gemini20FlashExperimental);
    }

    /// <summary>
    /// Generates a response text based on the input message.
    /// </summary>
    /// <param name="request">The request containing the message to be analyzed.</param>
    /// <returns>A response containing the generated text or error message.</returns>
    [HttpPost("")]
    public async Task<IActionResult> GenerateText([FromBody] MessageRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Message))
            return BadRequest(new ApiResponse(400, EmptyMessageError));

        var responseText = await GenerateResponseFromGemini(request.Message);

        if (string.IsNullOrEmpty(responseText))
            return BadRequest(new ApiResponse(500, FailedGenerationError));

        return Ok(new ApiResponse(200, responseText));
    }

    private async Task<string?> GenerateResponseFromGemini(string message)
    {
        var response = await _model.GenerateContent(message);
        return response?.Text?.Trim();
    }
}

public class MessageRequest
{
    public required string Message { get; set; }
}



