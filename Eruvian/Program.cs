using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eruvian
{
    static class Program
    {
            //! правильный код и максимально проверки
            //профиль героя
            //сохранения/загрузка
            //случайное нападение
            //склад/инвентарь и экипировка персонажа
            //база данных
            //магазин
            //координаты комнаты/перемещние по координатам случайно
            //сервер/ сетевая игра
            //спавн монстров/кладов
            //перевести в мин графику WPF
            //картинки
            //управление с клавитуры/ атака в направлении курсора-нажатия 
            //скилы/дерево развития навыков
            //простой алгоритм поведения монстров
            //разные локации

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
