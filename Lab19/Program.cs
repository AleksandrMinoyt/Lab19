using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computers> compList = new List<Computers>();
            List<Computers> compListFiltred = new List<Computers>();

            compList.Add(new Computers(1, "Офисный", "HP", "intel i3-3220", 3.3, 8, 320, 1, 50000, 1));
            compList.Add(new Computers(2, "Офисный топ", "HP", "intel i5-7100", 3.9, 16, 500, 2, 70000, 45));
            compList.Add(new Computers(3, "Игровой", "HP", "intel i5-7100", 3.3, 16, 1000, 4, 90000, 10));
            compList.Add(new Computers(4, "Игровой средний", "Depo", "intel i7 9700k", 4.9, 32, 1000, 6, 100000, 4));
            compList.Add(new Computers(5, "Для 3D", "HP", "intel i9-12900K", 5.2, 128, 2000, 16, 3000000, 4));
            compList.Add(new Computers(6, "Офисный для БД ", "Depo", "intel i3-3220", 3.3, 8, 1000, 2, 55000, 9));
            compList.Add(new Computers(7, "Офисный средний", "Depo", "AMD Ryzen 5 3600", 3.6, 8, 500, 1, 60000, 2));
            compList.Add(new Computers(8, "Офисный большой диск", "Depo", "AMD Ryzen 5 3600", 3.6, 16, 2000, 1, 90000, 30));

            List<string> processors = compList.Select(x => x.ProcessorType).Distinct().ToList();

            #region  Выбор по процессору

            Console.WriteLine("Выберите процессор из возможных:");

            int iterator = 0;
            foreach (string proc in processors)
            {
                iterator++;
                Console.WriteLine(iterator + " " + proc);
            }
            Console.WriteLine();

            int numProc = Convert.ToInt32(Console.ReadLine());

            if (numProc <= iterator && numProc > 0)
            {
                Console.WriteLine("Выбран {0}", processors[numProc - 1]);
                Console.WriteLine("ПК с данным процессором:");
                compListFiltred = compList.Where(x => x.ProcessorType == processors[numProc - 1]).ToList();
                PirntCompInfo(compListFiltred);
            }
            Console.WriteLine("Нажмите любую кнопку для продолженя");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region выбор по оперативке
            Console.WriteLine("Введите мнимальный объем оперативнй памяти:");
            int ram = Convert.ToInt32(Console.ReadLine());

            compListFiltred = compList.Where(x => x.Ram >= ram).ToList();
            PirntCompInfo(compListFiltred);

            Console.WriteLine("Нажмите любую кнопку для продолженя");
            Console.ReadKey();
            Console.Clear();
            #endregion
         
            #region Весь список отсортированый по стоимости

            Console.WriteLine("Список отсортированый по стоимости:");
            PirntCompInfo(compList
                                  .OrderBy(x => x.Cost)
                                  .ToList());
            Console.WriteLine("Нажмите любую кнопку для продолженя");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Весь список сгруппированый по процессору

            Console.WriteLine("Весь список сгруппированый по процессору");
            var groupList = compList
                                  .GroupBy(x => x.ProcessorType)
                                  .ToList();

            foreach (var group in groupList)
            {
                Console.WriteLine("Группа: {0}", group.Key);
                PirntCompInfo(group.ToList());
            }


            Console.WriteLine("Нажмите любую кнопку для продолженя");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Самый дорогой и самый дешевый

            Console.WriteLine("Самый дорогой и самый дешевый");

            double costMin = compList.Min(x => x.Cost);
            double costMax = compList.Max(x => x.Cost);

            Console.WriteLine("ПК с минимальной стоимостью");
            compListFiltred = compList.Where(x => x.Cost== costMin).ToList();
            PirntCompInfo(compListFiltred);
            Console.WriteLine("ПК с максимальной стоимостью");
            compListFiltred = compList.Where(x => x.Cost == costMax).ToList();
            PirntCompInfo(compListFiltred);

            Console.WriteLine("Нажмите любую кнопку для продолженя");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Есть ли ПК в наличии больше 30 шт

            Console.WriteLine("Есть ли ПК в наличии больше 30 шт");
         
            compListFiltred = compList.Where(x => x.Count>=30).ToList();

            Console.WriteLine("Больше 30 шт {0} модели", compListFiltred.Count);

            PirntCompInfo(compListFiltred);

            Console.WriteLine("Нажмите любую кнопку для продолженя");
            Console.ReadKey();
            Console.Clear();
            #endregion
            
        }

        public static void PirntCompInfo(List<Computers> list)
        {
            foreach (Computers comp in list)
            {
                Console.WriteLine("\nКод:{0} Название:{1} Марка:{2}\nПроцессор:{3} Частота:{4} Оперативка:{5} Диск:{6} Видео:{7}\nЦена:{8} В наличии:{9}\n",
                                   comp.Code,
                                   comp.Name,
                                   comp.Manufacturer,
                                   comp.ProcessorType,
                                   comp.ProcessorFrequency,
                                   comp.Ram,
                                   comp.HddVolume,
                                   comp.VideoRamVolume,
                                   comp.Cost,
                                   comp.Count);

            }

        }
    }
}
