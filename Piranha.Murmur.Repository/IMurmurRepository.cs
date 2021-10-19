using System;
using System.Threading;
using System.Threading.Tasks;

namespace Piranha.Murmur.Repository
{
    public interface IMurmurRepository
    {
        Task GetPostAsync(Guid postUuid, CancellationToken cancellationToken);
    }
}
