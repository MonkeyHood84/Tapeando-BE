using Tapeando.Data.Models;
using System.Data.Entity;
using MonkeyHood84.Common.Architecture;


namespace Tapeando.Services.Repositories
{
    public class PlaceRepository : GenericRepositoryEF<Place>
    {
        public PlaceRepository(DbContext context) : base(context) { }
    }
}
