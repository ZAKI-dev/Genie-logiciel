using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Genie_logiciel.Models;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Genie_logiciel.BusinessLayer
{
    internal interface InterfaceAccountManager
    {
        void AddCompte(Account c);
        void DelCompte(int id);
        Account SearchById(int id);
        DbSet<Account> GetComptes();
        bool Authenticate(Account c);
        void ModifyCompte(int id, Account c);
    }
}