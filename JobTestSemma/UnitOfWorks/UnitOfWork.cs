using JobTestSemma.core;
using JobTestSemma.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobTestSemma.UnitOfWorks
{ 
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;

        private RepositoryBase<Socio> _sociosRepository;
        private RepositoryBase<Barco> _barcosRepository;
        //private RepositoryBase<Patron> _patronsRepository;
       // private RepositoryBase<Salida> _salidasRepository;

        public RepositoryBase<Socio> Socios
        {
            get
            {
                if(this._sociosRepository == null)
                {
                    this._sociosRepository = new RepositoryBase<Socio>(this._context);
                }
                return this._sociosRepository;
            }
        }

        public RepositoryBase<Barco> Barcos
        {
            get
            {
                if (_barcosRepository == null)
                {
                    this._barcosRepository = new RepositoryBase<Barco>(_context);
                }
                return _barcosRepository;
            }
        }

        //public RepositoryBase<Patron> Patrons
        //{
        //    get
        //    {
        //        if (_patronsRepository == null)
        //        {
        //            this._patronsRepository = new RepositoryBase<Patron>(_context);
        //        }
        //        return _patronsRepository;
        //    }
        //}

        //public RepositoryBase<Salida> Salidas
        //{
        //    get
        //    {
        //        if (_salidasRepository == null)
        //        {
        //            this._patronsRepository = new RepositoryBase<Patron>(_context);
        //        }
        //        return _salidasRepository;
        //    }
        //}


        public UnitOfWork(DbContext context)
        {
            this._context = context;
        }
        public void Dispose()
        {
            this._context.Dispose();
        }

        public void Save()
        {
            this._context.SaveChanges();
        }
    }
}
