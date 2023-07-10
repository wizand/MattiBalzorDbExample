using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattiDb.Entities
{
    [Table(name:"mittaustulos")]
    public class Mittaustulos
    {
        [Key]
        public int MittaustulosId { get; set; }

        [StringLength(50)]
        public string Nimi { get; set; }
        public int? Arvo { get; set; }
        public DateTimeOffset InsertDate { get; set; }
    }
}
