using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using OhanaSupport.Models;

namespace OhanaSupport.Repositories {
    public class TagRepository: ITagRepository {
        private readonly ApplicationDbContext Context;

        public TagRepository(ApplicationDbContext context) {
            this.Context = context;
        }

        public async Task<List<Tag>> Get() {
            var tags = from tag in this.Context.Tags select tag;
            return await tags.ToListAsync();
        }

        public async Task<Tag> Get(Guid id) {
            var tag = from tg in this.Context.Tags where tg.Id.Equals(id) select tg;
            return await tag.FirstOrDefaultAsync();
        }
        
        public async Task Create(Tag tag) {
            tag.Id = Guid.NewGuid();

            await this.Context.Tags.AddAsync(tag);
            await this.Context.SaveChangesAsync();
        }

        public async Task Edit(Tag tag) {
            var tags = from t in this.Context.Tags where t.Id.Equals(tag.Id) select t;
            var tg = await tags.FirstOrDefaultAsync();

            tg.Text = tag.Text;

            await this.Context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            var tags = from tg in this.Context.Tags where tg.Id.Equals(id) select tg;
            var tag = await tags.FirstOrDefaultAsync();

            this.Context.Tags.Remove(tag);
            await this.Context.SaveChangesAsync();
        }
    }
}