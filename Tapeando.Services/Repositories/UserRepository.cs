using Tapeando.Data.Models;
using System.Data.Entity;
using MonkeyHood84.Common.Architecture;


namespace Tapeando.Services.Repositories
{
    public class UserRepository : GenericRepositoryEF<User>
    {
        public UserRepository(DbContext context) : base(context) { }
    }
}
