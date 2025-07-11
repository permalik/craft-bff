using Microsoft.AspNetCore.Mvc;
using CraftBff.Contracts.Turn;
using CraftBff.Models;
using CraftBff.Services;

namespace CraftBff.Controllers;

[ApiController]
[Route("controller")]
public class TurnControllers : ControllerBase
{
    private readonly ITurnService _turnService;

    public TurnControllers(ITurnService turnService)
    {
        _turnService = turnService;
    }
    
    [HttpPost()]
    public IActionResult CreateTurn(CreatePromptRequest request)
    {
        Prompt prompt = new Prompt(
            Guid.NewGuid(),
            request.Body
        );
        
        _turnService.CreatePrompt(prompt);

        PromptResponse response = new PromptResponse(
            prompt.Id,
            prompt.Body
        );

        return CreatedAtAction(
            actionName: nameof(GetTurn),
            routeValues: new { id = prompt.Id },
            response);
    }

    [HttpGet("{id:guid}")]
    public IActionResult GetTurn(Guid id)
    {
        return Ok(id);
    }

    [HttpDelete("{id:guid}")]
    public IActionResult DeleteTurn(Guid id)
    {
        return Ok(id);
    }
}