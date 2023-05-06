﻿using Dapper;
using System.Data.SqlClient;
using TransactionalAPIMaddiApp.Models;

namespace TransactionalAPIMaddiApp.Repository.Procedure
{
    public class RepositoryProcedure : IRepositoryProcedure
    {
        private readonly string connectioString;

        public RepositoryProcedure(IConfiguration configuration)
        {
            connectioString = configuration.GetConnectionString("DefaultConnection");
        }
        public async Task<dynamic> ExecProcedure(ProcedureViewModel procedure)
        {
            try
            {
                using var connection = new SqlConnection(connectioString);
                return await connection.QueryAsync(@"EXEC " + procedure.Procedure + "");
            }
            catch
            {
                return new {Rpta = "Error en la transacción", Cod = "-1"};
            }
        }
    }
}