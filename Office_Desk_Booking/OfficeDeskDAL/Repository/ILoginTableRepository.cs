using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public interface ILoginTableRepository
    {
        public int[] Login(LoginTable loginTable);
        public int AddLoginTable(LoginTable loginTable);

        public LoginTable ForgetPassword(LoginTable loginTable);

        public void UpdatePassword(LoginTable login);
    }
}
