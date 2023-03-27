using OfficeDeskEntity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeDeskDAL.Repository
{
    public interface IQRScannerRepository
    {
        void AddQScanner(QRScanner qScanner);
        void DeleteQScanner(int qScannerId);
        IEnumerable<QRScanner> GetQScanner();
        QRScanner GetQScannerById(int qScannerId);
        void UpdateQScanner(QRScanner qScanner);
    }
}
