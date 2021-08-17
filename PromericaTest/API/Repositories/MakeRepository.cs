using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Infra;
using System.Data.SqlClient;
using Dapper;

namespace API.Repositories
{
    public class MakeRepository : IMakeRepository
    {
        private SQLConfiguration _sqlConfiguration;

        public MakeRepository(SQLConfiguration configuration)
        {
            _sqlConfiguration = configuration;
        }


        protected SqlConnection dbConnection()
        {
            return new SqlConnection(_sqlConfiguration.ConnectionString);
        }

        public Task<bool> DeleteMake()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Make>> GetAllMakes()
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id, name, country 
                        FROM Make ";

            return await db.QueryAsync<Make>(sql, new { });
        }

        public async Task<Make> GetMake(int id)
        {
            var db = dbConnection();

            var sql = @"
                        SELECT id, name, country 
                        FROM Make 
                        WHERE id = @Id";

            return await db.QueryFirstOrDefaultAsync<Make>(sql, new { Id = id });
        }

        public Task<bool> InsertMake()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateMake()
        {
            throw new NotImplementedException();
        }
    }
}
