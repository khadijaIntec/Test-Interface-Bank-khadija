using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_Bank_khadija.Interfaces
{
    interface ITransaction
    {
        void ShowTransaction();
        double GetAmount();
        string ShowBankName();
    }
}


