using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eruvian
{
    class Adventures
    {
        
        public static void Start()
        {
            Adventures A = new Adventures(); A.Randomly();
        }

        public void Randomly()
        {
            try
            {
                Timer timer = null;
                TimerCallback timercallback = new TimerCallback(MonsterCheck);
                timer = new Timer(timercallback, null, 0, 1000);
            }
            catch (Exception ex) {
                MainWindow.WriteLog(" |||||||||  " + "В Process");
                MainWindow.WriteLog(ex.Message);
                MainWindow.WriteLog(ex.StackTrace);
            }
        }

        public void MonsterCheck(object state)
        {
            double spawnChance = 0.5;
            Random random = new Random();
            double check = random.NextDouble();
            if (check <= spawnChance) { MainWindow.WriteLog("Monster defeated!"); Program.MW.UP.Gold += 10; }
        }
    }
}
