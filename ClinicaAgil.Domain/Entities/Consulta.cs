using ClinicaAgil.Domain.Enums;

namespace ClinicaAgil.Domain.Entities;

public class Consulta
{
    public Guid Id { get; private set; }
    public Guid MedicoId { get; private set; }
    public string NomePaciente { get; private set; } = string.Empty;
    public DateTime DataHora { get; private set; }
    public int DuracaoMinutos { get; private set; }
    public StatusEnum Status { get; private set; }
    public string Observacao { get; private set; } = string.Empty;
    public DateTime CriadoEm { get; private set; }
    public DateTime AtualizadoEm { get; private set; }
    public Medico Medico { get; private set; } = null!;
}