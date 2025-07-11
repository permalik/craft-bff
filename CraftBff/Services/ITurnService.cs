using CraftBff.Contracts.Turn;
using CraftBff.Models;

namespace CraftBff.Services;

public interface ITurnService
{
    void CreatePrompt(Prompt prompt);
}