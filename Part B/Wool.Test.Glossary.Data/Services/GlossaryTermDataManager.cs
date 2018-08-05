using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wool.Test.Glossary.Data.Contracts;
using Wool.Test.Glossary.Data.Entities;

namespace Wool.Test.Glossary.Data.Services
{
    public class GlossaryTermDataManager : IGlossaryTermDataManager
    {
        private readonly GlossaryDBContext _glossaryDBContext;
        public GlossaryTermDataManager(GlossaryDBContext glossaryDBContext)
        {
            _glossaryDBContext = glossaryDBContext;
        }

        public async Task<int> Create(GlossaryTerm glossaryTerm)
        {
            var newEnitity = _glossaryDBContext.GlossaryTerms.Add(new GlossaryTerm()
            {
                Term = glossaryTerm.Term,
                Definition = glossaryTerm.Definition
            });
            await _glossaryDBContext.SaveChangesAsync();
            return newEnitity.Entity.Id;
        }

        public async Task<List<GlossaryTerm>> GetAll()
        {
            var _list = await _glossaryDBContext.GlossaryTerms.ToListAsync();
            return _list.OrderBy(gt => gt.Term).ToList();
        }

        public async Task Update(GlossaryTerm glossaryTerm)
        {
            _glossaryDBContext.GlossaryTerms.Update(glossaryTerm);
            await _glossaryDBContext.SaveChangesAsync();
        }

        public async Task Delete(GlossaryTerm glossaryTerm)
        {
            _glossaryDBContext.GlossaryTerms.Remove(glossaryTerm);
            await _glossaryDBContext.SaveChangesAsync();
        }
    }
}
