using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGBank.Data
{
    public static class AccountRepositoryFactory
    {
        public static AccountReopsitory CreateAccountReopsitory()
        {
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();

            AccountReopsitory repo;
            switch (mode.ToUpper())
            {
                case "TEST":
                    repo = new inMemoryRepository();
                    break;
                case "PROD":
                    repo = new FileRepository();
                    break;
                default:
                    throw new Exception("I dont know that mode");
            }
            return repo;
        }
    }
}
