using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Eruvian.MainWindow;

namespace Eruvian
{
    public class UserProfile
    {
        public delegate void GoldUpdateHandler();
        public event GoldUpdateHandler GoldUpdate;

        private int uGold = 0;

        public int Gold
        {
            get
            {
                return uGold;
            }
            set
            {
                uGold = value;
                GoldUpdate();
            }
        }
    }
}
