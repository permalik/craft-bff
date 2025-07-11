namespace CraftBff.Models;

public class Prompt
{
    public Guid Id { get; set; }
    public string Body { get; set; }

    public Prompt(Guid id, string body)
    {
        Id = id;
        Body = body;
    }
}