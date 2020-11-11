using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using OhanaSupport.Models;
using OhanaSupport.Enumerators;

namespace OhanaSupport.Repositories {
    public class LinkRepository: ILinkRepository {
        private readonly ApplicationDbContext Context;

        public LinkRepository(ApplicationDbContext context) {
            this.Context = context;
        }

        public async Task<List<Link>> Get() {
            var links = from link in this.Context.Links select link;
            return await links.ToListAsync();
        }

        public async Task<Link> Get(Guid id) {
            var links = from link in this.Context.Links where link.Id.Equals(id) select link;
            return await links.FirstOrDefaultAsync();
        }

        public async Task<List<Link>> Search(string name = null, string origin = null, LinkType? linkType = null) {
            IQueryable<Link> query = this.Context.Links;
            if (!String.IsNullOrWhiteSpace(name)) query = query.Where(link => link.Name.Contains(name));
            if (!String.IsNullOrWhiteSpace(origin)) query = query.Where(link => link.Origin.Contains(origin));
            if (linkType != null) query = query.Where(link => link.Type == (LinkType)linkType);

            return await query.ToListAsync();
        }

        public async Task Create(Link link) {
            //var lnks = from link in this.Context.Links where lnk.Name == link.Name && lnk.Origin == link.Origin select link;
            //if (lnks.Count != 0) return;

            link.Id = Guid.NewGuid();
            link.CreatedAt = DateTime.Now;
            link.UpdatedAt = null;
            
            await this.Context.Links.AddAsync(link);
            await this.Context.SaveChangesAsync();
        }

        public async Task Edit(Link link) {
            var lnks = from lk in this.Context.Links where lk.Id.Equals(link.Id) select link;
            var lnk = await lnks.FirstOrDefaultAsync();

            //if (lnk == null) return;

            lnk.Name = link.Name;
            lnk.Description = link.Description;
            lnk.Origin = link.Origin;
            lnk.Published = link.Published;
            lnk.Type = link.Type;
            lnk.UpdatedAt = DateTime.Now;
            
            await this.Context.SaveChangesAsync();
        }

        public async Task Delete(Guid id) {
            //get only 1 link and then delete using method syntax  ABCDEFG CONTAINS ABC true
            var links = from lnk in this.Context.Links where lnk.Id.Equals(id) select lnk;
            var link = await links.FirstOrDefaultAsync();

            //if (link == null) return;

            this.Context.Links.Remove(link);
            await this.Context.SaveChangesAsync();
        }
    }
}
