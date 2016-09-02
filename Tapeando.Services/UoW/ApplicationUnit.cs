using Tapeando.Data.Models;
using Tapeando.Services;
using System;
using System.Linq;
using MonkeyHood84.Common.Architecture;


namespace Tapeando.Servicies.UoW
{
    public class ApplicationUnit : IDisposable
    {
       // private DataContext _context = new DataContext();
        private Tapeando.Data.Models.TapeandoContext _context = new Tapeando.Data.Models.TapeandoContext();

        private IRepository<Place> _places = null;
        private IRepository<Tapa> _tapas = null;
        private IRepository<User> _users = null;
        private IRepository<TempTest> _tests = null;

        public IRepository<Place> Place
        {
            get
            {
                if (this._places == null)
                {
                    this._places = new GenericRepositoryEF<Place>(this._context);
                }
                return this._places;
            }
        }

        public IRepository<Tapa> Tapa
        {
            get
            {
                if (this._tapas == null)
                {
                    this._tapas = new GenericRepositoryEF<Tapa>(this._context);
                }
                return this._tapas;
            }
        }
        
        public IRepository<User> Users
        {
            get
            {
                if (this._users == null)
                {
                    this._users = new GenericRepositoryEF<User>(this._context);
                }
                return this._users;
            }
        }

        public IRepository<TempTest> Tests
        {
            get
            {
                if (this._tests == null)
                {
                    this._tests = new GenericRepositoryEF<TempTest>(this._context);
                }
                return this._tests;
            }
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }


        public IQueryable<TempTest> GetAllTestActives() 
        {
            return this.Tests.GetAll().Where(p => p.IsActive == true);
        }

    }
}
