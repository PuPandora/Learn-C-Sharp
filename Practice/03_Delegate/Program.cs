using System;

namespace _03_Delegate
{
    class Unit
    {
        public string name { get; protected set; } = "UNKNOWN";
        public int hp { get; protected set; } = 0;
        public int maxHp { get; protected set; } = 0;
        public int damage { get; protected set; } = 0;
        public bool isDead { get; protected set; } = false;

        public delegate void AAction();
        public delegate void AAAction(Unit unit);
        public event AAAction OnDeath = delegate { };
        public event AAction OnAttack = delegate { };

        protected Unit(string name, int hp, int damage)
        {
            this.name = name;
            this.maxHp = hp;
            this.hp = maxHp;
            this.damage = damage;

            Console.WriteLine($"{name}이/가 생성되었습니다.");
        }

        public virtual void Attack(Unit unit)
        {
            if (isDead)
            {
                return;
            }

            unit.OnHit(this);

            // 공격을 알리는 이벤트
            OnAttack();
        }

        public virtual void OnHit(Unit unit)
        {
            hp -= unit.damage;

            if (hp < 0)
            {
                hp = 0;
                isDead = true;
            }

            PrintHP();

            if (isDead)
            {
                // 죽음을 알리는 이벤트
                OnDeath(this);
            }

        }

        public void Fight(Unit unit)
        {
            Console.WriteLine($"{name}이/가 {unit.name}와/과 전투를 시작합니다");

            while (!unit.isDead && !this.isDead)
            {
                Attack(unit);
                unit.Attack(this);
            }
        }

        public void PrintHP()
        {
            Console.WriteLine($"{name}의 HP : {hp} / {maxHp}");
        }
    }

    class Player : Unit
    {
        public Player(string name, int hp, int damage) : base(name, hp, damage)
        {

        }
    }

    class Monster : Unit
    {
        public Monster(string name, int hp, int damage) : base(name, hp, damage)
        {

        }
    }

    class Program
    {

        static void OnUnitDeath(Unit unit)
        {
            Console.WriteLine($"유닛 {unit.name}이/가 사망했습니다.");
            unit.OnDeath -= OnUnitDeath;
        }

        static void PlayerMonster()
        {
            Monster myMonster = new Monster("Orc", 50, 5);
            Player myPlayer = new Player("Hoyo", 100, 10);

            myPlayer.OnDeath += OnUnitDeath;
            myMonster.OnDeath += OnUnitDeath;

            myPlayer.Fight(myMonster);
        }

        static void YoutubeSubscribeSystem()
        {
            Youtuber Lala = new Youtuber("라라");
            Youtuber Nana = new Youtuber("나나");
            Subscriber subscriberA = new Subscriber("렌");

            subscriberA.Subscribe(Lala);
            subscriberA.Subscribe(Nana);

            Lala.UploadVideo("나의 첫 게임 플레이 영상");
            Nana.UploadVideo("C# 프로그래밍 강좌 | 34");

            subscriberA.Subscribe(Lala);
            subscriberA.DeSubscribe(Lala);
            subscriberA.DeSubscribe(Nana);

            Lala.UploadVideo("비공개 동영상");
            Lala.RemoveVideo(Lala.YoutubeVideos[1]);

            subscriberA.WatchVideo(Lala.YoutubeVideos[0]);
            subscriberA.Subscribe(Lala);
        }

        static void Main(string[] args)
        {
            //PlayerMonster();

            YoutubeSubscribeSystem();
        }
    }
}
