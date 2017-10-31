using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Billing.Models;
using Billing.Repositories;

namespace Billing.Controllers
{
    public class HomeController : Controller
    {
        private readonly TransactionRepository _transactionRepository;
        private readonly CurrencyBillRepository _currencyBillRepository;

        public HomeController(TransactionRepository transactionRepository, CurrencyBillRepository currencyBillRepository)
        {
            _transactionRepository = transactionRepository;
            _currencyBillRepository = currencyBillRepository;
        }

        public async Task<IActionResult> Index()
        {
            HomePageViewModel model = new HomePageViewModel()
            {
                Transactions = await _transactionRepository.GetAll(),
                CurrencyBills = await _currencyBillRepository.GetAll()
            };
            return View(model);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
