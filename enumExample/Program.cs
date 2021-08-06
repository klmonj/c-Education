using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumExample
{
    enum ITEMTYPE //명찰에 가까운값(값형)
    {
        EQIP, //장비
        POTION, //포션
        QUEST, //퀘스트
        NONESELECT //선택x
    }
    class Item
    {
        public ITEMTYPE ItemType = ITEMTYPE.NONESELECT;

        public void PotionTypeSetting()
        {
            ItemType = ITEMTYPE.POTION;
        }
}
    class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            NewItem.ItemType = ITEMTYPE.POTION;
            NewItem.PotionTypeSetting();

            Console.WriteLine(ITEMTYPE.POTION);
            ITEMTYPE Type = ITEMTYPE.POTION;
            switch (Type)
            {
                case ITEMTYPE.EQIP:
                    break;
                case ITEMTYPE.POTION:
                    break;
                case ITEMTYPE.QUEST:
                    break;
                case ITEMTYPE.NONESELECT:
                    break;
                default:
                    break;
            }
        }
    }
}
