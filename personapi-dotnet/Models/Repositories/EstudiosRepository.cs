using Microsoft.EntityFrameworkCore;
using personapi_dotnet.Models.Entities;
using personapi_dotnet.Models.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace personapi_dotnet.Models.Repositories
{
    public class EstudiosRepository : IEstudiosRepository
    {
        private readonly PersonaDbContext _context;

        public EstudiosRepository(PersonaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Estudios>> GetAllAsync()
        {
            return await _context.Estudios.ToListAsync();
        }

        public async Task<Estudios> GetByIdAsync(int id)
        {
            return await _context.Estudios.FindAsync(id);
        }

        public async Task AddAsync(Estudios estudios)
        {
            await _context.Estudios.AddAsync(estudios);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Estudios estudios)
        {
            _context.Estudios.Update(estudios);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var estudios = await _context.Estudios.FindAsync(id);
            if (estudios != null)
            {
                _context.Estudios.Remove(estudios);
                await _context.SaveChangesAsync();
            }
        }
    }
}
