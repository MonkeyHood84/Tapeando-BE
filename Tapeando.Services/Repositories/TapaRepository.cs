using Tapeando.Data.Models;
using System.Data.Entity;
using MonkeyHood84.Common.Architecture;


namespace Tapeando.Services.Repositories
{
    public class TapaRepository : GenericRepositoryEF<Tapa>
    {
        public TapaRepository(DbContext context) : base(context) { }
    }
}
