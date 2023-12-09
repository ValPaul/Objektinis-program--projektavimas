using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.P2.Iterator
{
    public class BombLogCollection : ICollection
    {

        BombLog[] bombLogList;
        int numberofItems = 0;
        const int MAX_ITEMS = 20;

        public BombLogCollection()
        {
            bombLogList = new BombLog[MAX_ITEMS];
        }
        public void addItem(String str)
        {
            BombLog bombLog = new BombLog(str);
            if (this.numberofItems >= MAX_ITEMS)
                Console.WriteLine("Full");
            else
            {
                bombLogList[this.numberofItems] = bombLog;
                numberofItems = numberofItems + 1;
            }
        }
        public IIterator createIterator()
        {
            return new BombLogIterator(bombLogList);
        }
    }
}
