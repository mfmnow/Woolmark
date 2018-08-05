using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wool.Test.Glossary.Data.Entities
{
    public class GlossaryTerm
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Term { get; set; }
        public string Definition { get; set; }
    }
}
