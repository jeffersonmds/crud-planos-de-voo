﻿namespace Saipher.Infra.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
