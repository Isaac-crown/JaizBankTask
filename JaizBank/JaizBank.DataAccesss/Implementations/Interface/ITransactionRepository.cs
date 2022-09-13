using JaizBank.Entities.JaizBankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.DataAccesss.Implementations.Interface
{
    public interface ITransactionRepository
    {
        Task<List<Transactions>> GetAllTransactions();

    }
}
