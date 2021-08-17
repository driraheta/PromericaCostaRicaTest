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

        public async Task<bool> DeleteMake(Make make)
        {
            var db = dbConnection();

            var sql = @"
                        DELETE
                        FROM Make 
                        WHERE id = @Id";

            var result =  await db.ExecuteAsync(sql, new { Id = make.Id });
            return result > 0;
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

        public async Task<bool> InsertMake(Make make)
        {
            var db = dbConnection();

            var sql = @"
                        INSERT INTO Make (name, country) 
                        VALUES (@Name, @Country) ";

            var result = await db.ExecuteAsync(sql, new { make.Name, make.Country });
            return result > 0;
        }

        public async Task<bool> UpdateMake(Make make)
        {
            var db = dbConnection();

            //var sql = @"
            //            UPDATE Make SET name = @Name, country = @Country 
            //            WHERE id = @Id ";

            var param = new DynamicParameters();
            param.Add("@Id", make.Id);
            param.Add("@Name", make.Name);
            param.Add("@Country", make.Country);

            var storeProcedure = "sp_updatemake";

            //var result = await db.ExecuteAsync(sql, new { make.Name, make.Country, make.Id });
            var result = await db.ExecuteAsync(storeProcedure, param, commandType: System.Data.CommandType.StoredProcedure);
            return result > 0;
        }
    }
}
