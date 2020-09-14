using My.Core.Repositories;
using System;
using System.Threading.Tasks;

namespace My.Core
{
    public interface IUnitOfWork: IDisposable
    {
        IMusicRepository Musics { get; }
        IArtistRepository Artists { get; }
        Task<int> CommitAsync();
    }
}
