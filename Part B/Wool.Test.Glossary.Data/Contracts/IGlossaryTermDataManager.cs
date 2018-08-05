using System.Collections.Generic;
using System.Threading.Tasks;
using Wool.Test.Glossary.Data.Entities;

namespace Wool.Test.Glossary.Data.Contracts
{
    public interface IGlossaryTermDataManager
    {
        Task<List<GlossaryTerm>> GetAll();
        Task<int> Create(GlossaryTerm glossaryTerm);
        Task Update(GlossaryTerm glossaryTerm);
        Task Delete(GlossaryTerm glossaryTerm);
    }
}
