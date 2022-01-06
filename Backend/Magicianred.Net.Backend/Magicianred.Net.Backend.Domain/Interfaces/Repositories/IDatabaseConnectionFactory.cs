using System.Data;

namespace Magicianred.Net.Backend.Domain.Interfaces.Repositories
{
    public interface IDatabaseConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
