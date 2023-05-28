using Microsoft.EntityFrameworkCore;

namespace SweetBites.ServerApp.Data
{
    public class SweetService
    {
        private readonly AppDbContext _context;
        public SweetService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Sweet>> GetSweets()
        {
            return await _context.Sweets.ToListAsync();
        }
        public async Task<Sweet> GetSweetById(string name)
        {
            return await _context.Sweets.FirstOrDefaultAsync(s => s.Name == name);
        }
        public async Task AddSweet(Sweet sweet)
        {
            _context.Sweets.Add(sweet);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateSweet(Sweet sweet)
        {
            _context.Sweets.Update(sweet);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteSweet(string name)
        {
            var sweet = await _context.Sweets.FirstOrDefaultAsync(s => s.Name == name);
            if (sweet != null)
            {
                _context.Sweets.Remove(sweet);
                await _context.SaveChangesAsync();
            }
        }
    }
}
