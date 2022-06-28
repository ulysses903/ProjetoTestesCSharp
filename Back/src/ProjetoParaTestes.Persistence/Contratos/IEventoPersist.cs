using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjetoParaTestes.Domain;

namespace ProjetoParaTestes.Persistence.Contratos
{
    public interface IEventoPersist
    {
        Task<Evento[]> GetAllEventosAsync(bool includePalestrantes = false);
        Task<Evento> GetEventoByIdAsync(int eventoId, bool includePalestrantes = false);
    }
}