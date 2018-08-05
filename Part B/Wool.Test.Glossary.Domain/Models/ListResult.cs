using System.Collections.Generic;
using Wool.Test.Glossary.Data.Entities;

namespace MFM.CI.Implementation
{
    public class ListResult
    {
        public bool Success { get; set; }
        public IList<GlossaryTerm> GlossaryTerms { get; set; }
        public string Message { get; set; }
    }
}
