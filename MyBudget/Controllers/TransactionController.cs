﻿using MyBudget.Controllers.Interface;
using MyBudget.Core;
using MyBudget.Models.Transactions;
using MyBudget.Services;
using MyBudget.Views.Interface;
using MyBudget.Views.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBudget.Controllers
{
    public class TransactionController : ITransactionController
    {
        ITransactionView _transactionView;
        TransactionService _transactionService = new TransactionService();

        public TransactionController()
        {

        }
        public TransactionController(ITransactionView transactionView)
        {
            _transactionView = transactionView;
            _transactionView.SetController(this);
        }
        public void AddTransactions(IList<BasicTransaction> transactions)
        {
            _transactionService.AddTransactions(transactions);
        }

        public BasicTransaction GetTransaction(int id)
        {
            return _transactionService.GetTransaction(id);
        }

        public IList<BasicTransaction> GetTransactions()
        {
            return _transactionService.GetAllTransactions();
        }

        public void InitializeData()
        {
            _transactionService.InitializeData();
        }

        public void LoadTransactions()
        {
            var transactionList = MapViewData(GetTransactions());

            _transactionView.LoadTransactions(transactionList);
        }

        public bool RemoveTransaction(int id)
        {
            return _transactionService.RemoveTransaction(id);
        }

        public void UpdateTransaction(BasicTransaction transaction)
        {
            _transactionService.UpdateTransaction(transaction);
        }
        public void GetFilteredTransactions(DateTime start, DateTime end, BasicTransaction.TRANSACTION_TYPE type, bool isRecurring, bool isCredit)
        {
            IList <BasicTransaction> data = _transactionService.GetFilteredTransactions(start, end, type, isRecurring, isCredit);
            IList<TransactionViewData> viewData = MapViewData(data);

            _transactionView.LoadTransactions(viewData);
        }
        public void GetTransactions(DateTime start, DateTime end)
        {
            IList<BasicTransaction> data = _transactionService.GetAllTransactions(start, end);
            IList<TransactionViewData> viewData = MapViewData(data);

            _transactionView.LoadTransactions(viewData);
        }

        private IList<TransactionViewData> MapViewData(IList<BasicTransaction> data)
        {
            return data.Select(x => new TransactionViewData()
            {
                Id = x.Id,
                Amount = x.Amount,
                Date = x.Date.ToString(ThemeConstant.DATE_FORMAT),
                Type = (int)x.Type,
                Category = x.Category.Name
            }).ToList();
        }

        
    }
}
