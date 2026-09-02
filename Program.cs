using JobTracker.Models;

var application = new JobApplication();

application.Company = "Microsoft";
application.Position = "Junior .NET Developer";
application.JobUrl = "https://exemplo.com/vaga";
application.Salary = 4500.00m;
application.WorkMode = "Remote";
application.ApplicationDate = DateTime.Now;
application.Status = "Applied";
application.Description = "Junior backend developer position.";
application.Notes = "Application sent through company website.";
application.RequiredTechnologies = new List<string>
{
    "C#",
    ".NET",
    "SQL"
};

Console.WriteLine("=== JOB TRACKER ===");
Console.WriteLine($"Empresa: {application.Company}");
Console.WriteLine($"Cargo: {application.Position}");
Console.WriteLine($"Salário: R$ {application.Salary:F2}");
Console.WriteLine($"Modalidade: {application.WorkMode}");
Console.WriteLine($"Status: {application.Status}");
Console.WriteLine($"Data: {application.ApplicationDate:dd/MM/yyyy}");

Console.WriteLine("Tecnologias:");

foreach (var technology in application.RequiredTechnologies)
{
    Console.WriteLine($"- {technology}");
}