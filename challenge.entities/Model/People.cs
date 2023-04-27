using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace challenge.entities.Model
{
    [Serializable]
    [DataContract]
    public partial class People : IdentityBase
    {
        [DataMember]
        [Browsable(false)]
        [Required]
        [DisplayName("Nombre")]
        public string FirstName { get; set; }

        [DataMember]
        [Required]
        [DisplayName("Apellido")]
        public string LastName { get; set; }

        [DataMember]
        [Required]
        [DisplayName("País")]
        public string Country { get; set; }
    }
}
