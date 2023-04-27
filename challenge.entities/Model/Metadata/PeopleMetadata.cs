using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge.entities.Model.Metadata
{
    [MetadataType(typeof(PeopleMetadata))]
    public partial class PeopleMetadata
    {
        [DisplayName("First Name")]
        [Required(ErrorMessage = "Requerido")]
        [MaxLength(50, ErrorMessage = "Longitud  50 caracteres")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Requerido")]
        [MaxLength(50, ErrorMessage = "Longitud  50 caracteres")]
        public string LastName { get; set; }

        [DisplayName("Country")]
        [MaxLength(50, ErrorMessage = "Longitud  50 caracteres")]
        public string Country { get; set; }
    }
}
