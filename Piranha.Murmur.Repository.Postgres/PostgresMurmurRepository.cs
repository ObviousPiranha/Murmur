using System;
using System.Threading;
using System.Threading.Tasks;

namespace Piranha.Murmur.Repository.Postgres
{
    public class PostgresMurmurRepository : IMurmurRepository
    {
        public Task GetPostAsync(Guid postUuid, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
