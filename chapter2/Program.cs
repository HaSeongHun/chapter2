using System.Xml.Linq;
using System.Xml.Serialization;

namespace chapter2
{
    struct stat()
    {
        public int lev;
        public string job;
        public int att;
        public int def;
        public int hp;
        public int gold;

        public void viewstat()
        {
            Console.WriteLine("Lv : " + lev);
            Console.WriteLine("Chad : " + job);
            Console.WriteLine("공격력 : " + att);
            Console.WriteLine("방어력 : " + def);
            Console.WriteLine("체력 : " + hp);
            Console.WriteLine("Gold : " + gold);
        }
    }
    struct Item()
    {
        
    }
    internal class Start
    {
        static stat stat;

        static void Main()
        {
            stat.lev = 1;
            stat.job = "전사";
            stat.att = 10;
            stat.def = 5;
            stat.hp = 100;
            stat.gold = 1500;


            Console.WriteLine("스파르타 마을에 오신 여러분을 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
            Console.WriteLine();
            

            
            while (true)
            {
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine();
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                Console.Write(">> ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        checkstat();
                        break;
                    case 2:
                        checkinven();
                        break;
                    case 3:
                        shop();
                        break;
                    default:
                        Console.WriteLine("잘못된 행동입니다.");
                        break;
                }
            }
            static void checkstat()
            {
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");

                stat.viewstat();

                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                
                while (true)
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 행동입니다.");
                    }
                }
            }
            static void checkinven()
            {
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("");
                Console.WriteLine("[아이템 목록]");
                
                while (true)
                {
                    Console.WriteLine("1. 장착 관리");
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">> ");

                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        
                    }
                    else if (choice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 행동입니다.");
                    }
                }
            }
            static void shop()
            {
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 살 수 있는 상점입니다.");
                Console.WriteLine("");

                Console.WriteLine("[보유 골드]");
                Console.WriteLine(stat.gold + "G");

                Console.WriteLine("[아이템 목록]"); //아이템 방어력 / 아이템 설명 / 가격 설정해야됨
                //Console.WriteLine("- 수련자 갑옷 | 방어력 " + + + );

                while (true)
                {
                    Console.WriteLine("1. 아이템 구매");
                    Console.WriteLine("0. 나가기");
                    Console.WriteLine("원하시는 행동을 입력해주세요.");
                    Console.Write(">> ");

                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {

                    }
                    else if (choice == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 행동입니다.");
                    }
                }
            }
        }
    }
}
