using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using OhanaSupport.Models;

namespace OhanaSupport.Repositories {
    public interface ILinkRepository {
        Task<List<Link>> Get();
        Task<Link> Get(Guid id);
        Task Create(Link link);
        Task Edit(Link link);
        Task Delete(Guid id);
    }
}