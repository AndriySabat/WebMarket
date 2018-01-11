using System;
using System.Collections.Generic;
using System.Text;
using WebMarket.DAL.UnitOfWork;

namespace WebMarket.DAL.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork CreateUnitOfWork()
        {
            return new WebMarketUnitOfWork();
        }
    }
}
