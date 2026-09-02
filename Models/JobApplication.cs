namespace JobTracker.Models;

public class JobApplication
{
public string Company { get; set; } = string.Empty;
public string Position { get; set; } = string.Empty;
public string JobUrl { get; set; } = string.Empty;
public decimal Salary { get; set; }
public string WorkMode { get; set; } = string.Empty;
public DateTime ApplicationDate { get; set; }
public string Status { get; set; } = string.Empty;
public string Description { get; set; } = string.Empty;
public string Notes { get; set; } = string.Empty;
public List<string> RequiredTechnologies { get; set; } = new();
}