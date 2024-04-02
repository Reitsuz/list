using System;
using System.Collections.Generic;

namespace ListApp
{
    class Program
    {
        static List<string> myList = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("リスト");

            while (true)
            {
                Console.WriteLine("\nメニュー:");
                Console.WriteLine("1. アイテムを追加");
                Console.WriteLine("2. アイテムを表示");
                Console.WriteLine("3. アイテムを削除");
                Console.WriteLine("4. 終了");
                Console.Write("選択肢を入力: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        ViewItems();
                        break;
                    case 3:
                        RemoveItem();
                        break;
                    case 4:
                        Console.WriteLine("タスク終了！");
                        return;
                    default:
                        Console.WriteLine("無効な選択肢です。");
                        break;
                }
            }
        }

        static void AddItem()
        {
            Console.Write("アイテムを入力: ");
            string item = Console.ReadLine();
            myList.Add(item);
            Console.WriteLine("アイテムを追加！");
        }

        static void ViewItems()
        {
            Console.WriteLine("\nリスト内のアイテム:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }

        static void RemoveItem()
        {
            Console.Write("削除するアイテムを入力: ");
            string itemToRemove = Console.ReadLine();
            if (myList.Remove(itemToRemove))
            {
                Console.WriteLine("アイテムを削除！");
            }
            else
            {
                Console.WriteLine("リスト内でアイテムが見つかりません。");
            }
        }
    }
}
