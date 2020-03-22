using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Level4.DataLayer
{
    public interface IDbConnectionFactory
    {
        Task<IDbConnection> CreateConnectionAsync();
        Task SetupAsync();
    }
}
