
using ClinicaAgil.Domain.Entities;

namespace ClinicaAgil.Application.Interfaces;

public interface IMedicoRepositories
{
    Task<Medico> GetByIdAsync(Guid id);
    Task<IEnumerable<Medico>> GetAllAsync(int pageNumber, int pageSize);

    Task<Medico> AddAsync(Medico medico);
    Task UpdateAsync(Medico medico);
    Task<bool> DeleteAsync(Guid id);
}