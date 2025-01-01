using System.ComponentModel.DataAnnotations;

namespace CommandService.Entities;

public class Platform
{
    public int Id { get; set; }

    [Required]
    public int ExternalID { get; set; }

    [Required]
    public string Name { get; set; }

    public IEnumerable<Command> Commands { get; set; } = new List<Command>();
}