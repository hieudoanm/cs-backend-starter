using System;

namespace cs_backend_starter.Models;

public class Task
{
    public string? Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool Completed { get; set; }
}
