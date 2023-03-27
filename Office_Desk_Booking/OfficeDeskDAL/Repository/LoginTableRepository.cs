using Microsoft.EntityFrameworkCore;
using OfficeDeskDAL.Data;
using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public class LoginTableRepository:ILoginTableRepository
    {
        DeskDbContext _db;
        public LoginTableRepository(DeskDbContext db)
        {
            _db = db;
        }



        public int AddLoginTable(LoginTable loginTable)
        {
            _db.LoginTables.Add(loginTable);
            _db.SaveChanges();
            List<LoginTable> list = new List<LoginTable>();
            list = _db.LoginTables.ToList();
            var loginTable1 = (from list1 in list
                               select list1).Last();
            return loginTable1.ID;
        }
        public int[] Login(LoginTable loginTable)
        {
            int[] arr = { -1, 4 };
            List<LoginTable> LoginLists = _db.LoginTables.ToList();
            var TotalList = from v in LoginLists select v;
            if (loginTable.Email == "deskify@gmail.com" && loginTable.Password == "deskify123")
            {
                arr[1] = 3;
                return arr;
            }
            else
            {
                foreach (var i in TotalList)
                {
                    if (i.Email == loginTable.Email && i.Password == loginTable.Password)
                    {
                        arr[0] = i.ID;
                        arr[1] = i.Type;
                    }
                }
            }
            return arr;

        }

        public LoginTable ForgetPassword(LoginTable loginTable)
        {
           
            List<LoginTable> LoginLists = _db.LoginTables.ToList();
            var TotalList = from v in LoginLists select v;
            LoginTable loginTable1 = new LoginTable();
            

            foreach (var i in TotalList)
            {
                if (i.Email == loginTable.Email)
                {
                    return i;
                }
            }

            return loginTable1;

        }
        public void UpdatePassword(LoginTable login)
        {          
            _db.Entry(login).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
