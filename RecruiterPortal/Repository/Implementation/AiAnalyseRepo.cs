using Microsoft.EntityFrameworkCore;
using RecruiterPortal.Controllers.Request.Application;
using RecruiterPortal.Model;
using RecruiterPortal.Repository.Interfaces;

namespace RecruiterPortal.Repository.Implementation
{
    public class AiAnalyseRepo : BaseRepo<AnaliseAiDataModel>, IAiAnalyseRepo
    {
        public AiAnalyseRepo(AppDbContext context) : base(context, x=>x.AnaliseAiData)
        {
        }

        public async Task<List<AnaliseAiDataModel>> GetAnaliseAiData()
        {
            return await _dbSet
                .AsNoTracking()
                .OrderBy(x=>x.Id)
                .ToListAsync();
        }

        public async  Task SaveAiAnalyse(AnalyseAiRequest newAiAnalyse)
        {
            await _dbSet.AddAsync(newAiAnalyse);
            await _context.SaveChangesAsync();
        }
    }
}
