using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using OhanaSupport.Models;

namespace OhanaSupport.Repositories {
    public interface ITagRepository {
        Task<List<Tag>> Get();
        Task<Tag> Get(Guid id);
        Task Create(Tag tag);
        Task Edit(Tag tag);
        Task Delete(Guid id);
    }
}