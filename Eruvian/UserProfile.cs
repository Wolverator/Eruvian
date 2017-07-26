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
        //Приватные данные
        private Inventory _inventory;
        private MainWindow MW;

        public UserProfile(MainWindow mainWindow)
        {
            MW = mainWindow;
            _inventory = new Inventory(mainWindow);
        }

        //Свойства
        private void WriteLog()
        {
            MW.WriteLog("SomeString");
        }
        public Object this[int index]
        {
            set
            {
                //Необходимо добавить проверки
                _inventory.Thing[index] = value;
            }
            get
            {
                return _inventory.Thing[index];
            }
        }

        //Тестовая часть с событиями
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
                WriteLog();
            }
        }
    }
}
