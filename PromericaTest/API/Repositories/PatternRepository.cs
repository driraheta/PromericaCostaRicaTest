using API.Infra;
using API.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories
{
    public class PatternRepository : IPatternRepository
    {
        private SQLConfiguration _sqlConfiguration;

        public PatternRepository(SQLConfiguration sqlConfiguration)
        {
            _sqlConfiguration = sqlConfiguration;
        }
        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_sqlConfiguration.ConnectionString);
        }

        public async Task<bool> DeletePattern(Pattern pattern)
        {
            var db = dbConnection();

            var param = new DynamicParameters();
            param.Add("@Id", pattern.Id);
            var storeProcedure = "sp_deletepattern";

            var result = await db.ExecuteAsync(storeProcedure, param, commandType: System.Data.CommandType.StoredProcedure);
            return result > 0;
        }

        public async Task<IEnumerable<Pattern>> GetAllPatterns()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id, make_id, name, color, year, doors 
                        FROM Pattern ";

            return await db.QueryAsync<Pattern>(sql, new { });
        }

        public async Task<IEnumerable<Pattern>> GetPatterns(int makeId)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id, make_id, name, color, year, doors 
                        FROM Pattern WHERE make_id = @MakeId";

            return await db.QueryAsync<Pattern>(sql, new { MakeId = makeId });
        }

        public async Task<Pattern> GetPattern(int id)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id, make_id, name, color, year, doors 
                        FROM Pattern WHERE id = @Id";

            var result= await db.QueryFirstOrDefaultAsync<Pattern>(sql, new { Id = id });
            return result;
        }
    }
}
