﻿using System;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        ILotRepository Lots { get; }
        IAuctionRepository Auctions { get; }
        ICategoryRepository Categories { get; }

        void Commit();
    }
}
