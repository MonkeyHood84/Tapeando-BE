using Tapeando.Data.Models.MetaData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapeando.Data.Models
{
    [MetadataType(typeof(TempTestMDT))]
    public partial class TempTest { }

    public partial class User { }
}
