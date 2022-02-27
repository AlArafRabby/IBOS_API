using ControlPanel.DTO.AccountingJournalCodeGenerator;
using ControlPanellNew.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlPanel.IRepository
{
   public interface IAccountingJournalCodeGenerator
    {
        Task<Message> GetAccountingJournalCodeGeneratorId(long UnitId);
        Task<Message> CreateAccountingJournalCodeGenerator(CreateAccountingJournalCodeGenerator postAccountingJournalCodeGenerator);
    }
}
