using System.Collections.Generic;
using System.Threading.Tasks;
using Wool.Test.Glossary.Data.Contracts;
using Wool.Test.Glossary.Data.Entities;
using Wool.Test.Glossary.Domain.Contacts;

namespace Wool.Test.Glossary.Domain.Services
{
    public class GlossaryTermDomainManager : IGlossaryTermDomainManager
    {
        private readonly IGlossaryTermDataManager _glossaryTermDataManager;

        public GlossaryTermDomainManager(IGlossaryTermDataManager glossaryTermDataManager)
        {
            _glossaryTermDataManager = glossaryTermDataManager;
        }

        public async Task<int> Save(GlossaryTerm glossaryTerm)
        {
            if (glossaryTerm.Id == 0)
            {
                return await _glossaryTermDataManager.Create(glossaryTerm);
            }
            else
            {
                await _glossaryTermDataManager.Update(glossaryTerm);
            }
            return glossaryTerm.Id;
        }

        public async Task<List<GlossaryTerm>> GetAll()
        {
            return await _glossaryTermDataManager.GetAll();
        }

        public async Task Delete(GlossaryTerm glossaryTerm)
        {
            await _glossaryTermDataManager.Delete(glossaryTerm);
        }
    }
}
