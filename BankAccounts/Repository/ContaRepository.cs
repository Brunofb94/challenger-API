using System;
using System.Collections.Generic;
namespace BankAccounts.Repository
{
    public interface ContaRepository : IDisposable
    {
        models.ContaPoupanca GetByID(int id);                
        void Save();

    }
}