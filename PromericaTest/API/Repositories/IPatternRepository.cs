using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;

namespace API.Repositories
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPatternRepository
    {
        Task<IEnumerable<Pattern>> GetAllPatterns();
        Task<IEnumerable<Pattern>> GetPatterns(int makeId);
        Task<Pattern> GetPattern(int id);
        Task<bool> DeletePattern(Pattern pattern);

    }
}
