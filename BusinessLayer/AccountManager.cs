using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Genie_logiciel.Models;

namespace Genie_logiciel.BusinessLayer
{
    public class AccountManager : InterfaceAccountManager
    {
         MyDBContext context = new MyDBContext();

        public void AddCompte(Account c)
        {
            context.comptes.Add(c);
            context.SaveChanges();
        }

        public bool Authenticate(Account c)
        {
            foreach (var item in context.comptes)
            {
                if (item.Id == c.Id && item.Pwd == c.Pwd)
                    return true;
            }
            return false;
        }

        public void DelCompte(int id)
        {
            foreach (var item in context.comptes)
            {
                if (item.Id == id)
                {
                    context.comptes.Remove(item);
                    break;
                }
            }
            context.SaveChanges();
        }

        public DbSet<Account> GetComptes()
        {
            return context.comptes;
        }

        public void ModifyCompte(int id, Account c)
        {
            foreach (var item in context.comptes)
            {
                if (item.Id == id)
                {
                    item.Id = c.Id;
                    item.Pwd = c.Pwd;
                    break;
                }
            }
            context.SaveChanges();
        }

        public Account SearchById(int id)
        {
            foreach (var item in context.comptes)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
    }
}
