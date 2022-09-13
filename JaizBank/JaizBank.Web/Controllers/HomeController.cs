
using JaizBank.DataAccesss.Implementations.Interface;
using JaizBank.DTOs.DTOs;
using JaizBank.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JaizBank.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITransactionRepository _transactionRepository;

        public HomeController(ILogger<HomeController> logger,
                             ITransactionRepository transactionRepository)
        {
            _logger = logger;
            _transactionRepository = transactionRepository;
        }

        public async Task<IActionResult> Index()
        {
            var trans = await _transactionRepository.GetAllTransactions();

          List<TransactionsViewModel> transactions = new List<TransactionsViewModel>();

            foreach (var transaction in trans)
            {
                var transview = new TransactionsViewModel()
                {
                    MerchantName = transaction.MerchantName,
                    Location = transaction.Location,
                    TerminalId = transaction.TerminalId,
                    Stan = transaction.Stan,
                    DateTime = transaction.DateTime,
                    ExpireDate = transaction.ExpireDate,
                    Amount = transaction.Amount,

                    
                    DebitCardNo = transaction.DebitCardNo,
                    AuthorizationCode = transaction.AuthorizationCode,
                    AID = transaction.AID,
                    RRN = transaction.RRN,
                    Accelerex = transaction.Accelerex,
                    PTAD = transaction.PTAD

                };

                transactions.Add(transview);
            }

            return View(transactions);






            return View(trans);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}