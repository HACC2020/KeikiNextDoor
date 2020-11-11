using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using OhanaSupport.Models;
using OhanaSupport.Enumerators;

namespace OhanaSupport.Repositories {
    public interface ILinkRepository {
        Task<List<Link>> Get();
        Task<Link> Get(Guid id);
        Task<List<Link>> Search(string name = null, string origin = null, LinkType? linkType = null);
        Task Create(Link link);
        Task Edit(Link link);
        Task Delete(Guid id);
    }
}