using ClinicaAgil.Domain.Enums;
namespace ClinicaAgil.Domain.Entities;

public class Medico
{
    public Guid Id { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Crm { get; private set; } = string.Empty;
    public EspecialidadeEnum Especialidade { get; private set; }
    public decimal ValorConsulta { get; private set; }
    public bool Ativo { get; private set; }
    public DateTime CriadoEm { get; private set; }
    public DateTime AtualizadoEm { get; private set; }
    public ICollection<Consulta> Consultas { get; private set; } = new List<Consulta>();
}