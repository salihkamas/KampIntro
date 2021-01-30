using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISalesService
    {
        void Sell(Gamer gamer,Sales sales,Campaign campaign);
    }
}
