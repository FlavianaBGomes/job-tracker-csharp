using JobTracker.Enums;
using JobTracker.Models;

Console.WriteLine("=== JOB TRACKER ===");
Console.WriteLine();

Console.Write("Empresa: ");
string company = Console.ReadLine() ?? string.Empty;

Console.Write("Cargo: ");
string position = Console.ReadLine() ?? string.Empty;

Console.Write("Link da vaga: ");
string jobUrl = Console.ReadLine() ?? string.Empty;

Console.Write("Salário: ");
decimal salary = decimal.Parse(Console.ReadLine() ?? "0");

Console.WriteLine();
Console.WriteLine("Modalidade:");
Console.WriteLine("1 - Remoto");
Console.WriteLine("2 - Híbrido");
Console.WriteLine("3 - Presencial");
Console.Write("Escolha: ");

int workModeOption = int.Parse(Console.ReadLine() ?? "1");

WorkMode workMode = workModeOption switch
{
    1 => WorkMode.Remote,
    2 => WorkMode.Hybrid,
    3 => WorkMode.OnSite,
    _ => WorkMode.Remote
};

Console.WriteLine();

Console.Write("Tecnologias exigidas (separe por vírgula): ");
string technologiesInput = Console.ReadLine() ?? string.Empty;

List<string> technologies = technologiesInput
    .Split(',')
    .Select(technology => technology.Trim())
    .ToList();

var application = new JobApplication
{
    Id = 1,
    Company = company,
    Position = position,
    JobUrl = jobUrl,
    Salary = salary,
    WorkMode = workMode,
    ApplicationDate = DateTime.Now,
    Status = ApplicationStatus.Saved,
    RequiredTechnologies = technologies
};

Console.WriteLine();
Console.WriteLine("=== VAGA CADASTRADA ===");
Console.WriteLine($"Empresa: {application.Company}");
Console.WriteLine($"Cargo: {application.Position}");
Console.WriteLine($"Salário: R$ {application.Salary:F2}");
Console.WriteLine($"Modalidade: {application.WorkMode}");
Console.WriteLine($"Status: {application.Status}");

Console.WriteLine("Tecnologias:");

foreach (var technology in application.RequiredTechnologies)
{
    Console.WriteLine($"- {technology}");
}