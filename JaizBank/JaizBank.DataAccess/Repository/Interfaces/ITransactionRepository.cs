using JaizBank.Entities.JaizBankModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.DataAccess.Repository.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transactions>> GetAllTransactions();
    }
}
