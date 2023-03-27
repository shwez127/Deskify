using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public interface IAdminRepository
    {
        void AddAdmin(Admin admin);
        void DeleteAdmin(int adminId);
        IEnumerable<Admin> GetAdmin();
        Admin GetAdminById(int adminId);
        void UpdateAdmin(Admin admin);
    }
}
