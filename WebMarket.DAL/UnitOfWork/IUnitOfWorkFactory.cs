using System;
using System.Collections.Generic;
using System.Text;

namespace WebMarket.DAL.UnitOfWork
{
    /// <summary>
    /// Interface IUnitOfWorkFactory
    /// </summary>
    public interface IUnitOfWorkFactory
    {
        /// <summary>
        /// Creates the WebMarket unit of work.
        /// </summary>
        /// <returns>IUnitOfWork.</returns>
        IUnitOfWork CreateUnitOfWork();
    }
}
