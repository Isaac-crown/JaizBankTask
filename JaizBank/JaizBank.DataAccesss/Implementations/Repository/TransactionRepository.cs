using JaizBank.Data.Data;
using JaizBank.DataAccesss.Implementations.Interface;
using JaizBank.Entities.JaizBankModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JaizBank.DataAccesss.Implementations.Repository
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly TransactionsContext _context;

        public TransactionRepository(TransactionsContext context)
        {
            _context = context;
        }
        public async Task<List<Transactions>> GetAllTransactions()
        {
            return  await _context.Transactions.ToListAsync();
        }
    }
}
