using JaizBank.Entities.JaizBankModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaizBank.Data.Data
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transactions>().HasData(


                new Transactions
                {
                    TransactionsId = 1,
                    MerchantName = "LIZPEE GLOBAL RESOURCES",
                    Location = "NO, 174 NTA/MBUORA RD, PORTHARCOURT",
                    TerminalId = "23011845",
                    Stan = "003862",
                    Amount = 1,
                    DebitCardNo = "539941******3369",
                    AuthorizationCode = 000000,
                    Offline = "CVM",
                    ResponseCode = 91,
                    AID = "A0000000041010",
                    RRN = "000210002450",
                    Accelerex = "2.0.0-090921-LINT",
                    PTAD = "Global Accelerex"
                    

                }

                );

        }

    }
}

