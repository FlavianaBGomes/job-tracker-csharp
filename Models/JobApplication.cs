using JobTracker.Enums;

namespace JobTracker.Models;

public class JobApplication
{
    public int Id { get; set; }

    public string Company { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string JobUrl { get; set; } = string.Empty;

    public decimal Salary { get; set; } //decimal é mais indicado para salário

    public WorkMode WorkMode { get; set; }

    public DateTime ApplicationDate { get; set; } //a data que a candidatura foi feita

    public ApplicationStatus Status { get; set; }

    public string Description { get; set; } = string.Empty;
    public string Notes { get; set; } = string.Empty;

    public List<string> RequiredTechnologies { get; set; } = new();
}