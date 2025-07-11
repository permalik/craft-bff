using CraftBff.Models;

namespace CraftBff.Services;

public class TurnService : ITurnService
{
    public void CreatePrompt(Prompt prompt)
    {
        Console.WriteLine("Creating prompt..");
    }
}