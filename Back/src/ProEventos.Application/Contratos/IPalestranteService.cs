using System.Threading.Tasks;
using ProEventos.Domain;

namespace ProEventos.Application.Contratos
{
    public interface IPalestranteService
    {
        Task<Evento> AddPalestrantes(Palestrante model);
        Task<Palestrante> UpdatePalestrante(int palestranteId, Palestrante model);
        Task<bool> DeletePalestrante(int palestranteId);

        Task<Palestrante[]> GetAllPalestrantesAsync(bool includePalestrantes = false);
        Task<Palestrante[]> GetAllPalestrantesByTemaAsync(string tema, bool includePalestrantes = false);
        Task<Palestrante> GetPalestranteByIdAsync(int palestranteId, bool includePalestrantes = false);
    }
}