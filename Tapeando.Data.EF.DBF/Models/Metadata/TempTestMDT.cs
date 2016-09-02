using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapeando.Data.Models.MetaData
{
    public class TempTestMDT
    {
        [Required]
        [MaxLength(50)]
        [Display(Name="Test Name")]
        public string Name;
    }
}
