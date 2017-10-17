using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeaBattle.Data.Model
{
    public class Battlefield
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "xml")]
        [Required] 
        public string placement { get; set; }
        
        [NotMapped]
        public XElement Placement
        {
            get { return XElement.Parse(placement); }
            set { placement = value.ToString(); }
        }

    }
}
