using System.Collections.Generic;
using System.Threading.Tasks;
using Wool.Test.Glossary.Data.Entities;

namespace Wool.Test.Glossary.Domain.Contacts
{
    public interface IGlossaryTermDomainManager
    {
        Task<List<GlossaryTerm>> GetAll();
        Task<int> Save(GlossaryTerm glossaryTerm);
        Task Delete(GlossaryTerm glossaryTerm);
    }
}
