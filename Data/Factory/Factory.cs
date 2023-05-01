using Data.Contracts;
using Data.Repositories;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Factory
{
    public sealed class Factory
    {
        #region Singleton
        private readonly static Factory _instance = new();
        private readonly DatabaseContext _db;
        public static Factory Current
        {
            get
            {
                return _instance;
            }
        }
        private Factory()
        {
            _db = new DatabaseContext();
            PeopleRepository = new GenericRepository<People>(_db);
        }
        #endregion
        public IGenericRepository<People> PeopleRepository { get; }
        public void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}