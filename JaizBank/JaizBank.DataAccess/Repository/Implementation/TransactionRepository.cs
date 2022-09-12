using JaizBank.Data.Data;
using JaizBank.DataAccess.Repository.Interfaces;
using JaizBank.Entities.JaizBankModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.DataAccess.Repository.Implementation
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly TransactionsContext _context;

        public TransactionRepository(TransactionsContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Transactions>> GetAllTransactions()
        {
            return await _context.Transactions.ToListAsync();
        }
    }
}
