﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eruvian
{
    public class Inventory
    {
        private uint _size = 10;
        private Object[] _thing;
        private MainWindow MW;

        public Object[] Thing
        {
            get
            {
                return _thing;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("Введи сюда подходящий текст ошибки");
                _thing = value;
            }
        }
        
        public Inventory(MainWindow mw)
        {
            _thing = new Object[_size];
            MW = mw;
        }
        private void WriteLog()
        {
            MW.WriteLog("ещё одна строка");
        }
        public void NewSize(uint size)
        {
            //создание массива вещей на основе существующего массива
        }
    }
}
