using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionVariable
{
    public delegate void P_Action();

    internal class Program
    {
        static void Main(string[] args)
        {
            var newPlayer = new Player();

            Console.WriteLine("플레이어 공격 기능 실행");
            newPlayer.attackFunc.Invoke();
            newPlayer.Attack();

            Console.WriteLine("플레이어 Func[0] 실행");
            newPlayer.playerFunc[0].Invoke();

            Console.WriteLine();
            Console.WriteLine("플레이어 Func[1] 실행");
            newPlayer.playerFunc[1].Invoke();

            Console.WriteLine();
            Console.WriteLine("플레이어 Func 전부 실행");
            foreach (var func in newPlayer.playerFunc)
            {
                func.Invoke();
            }

            newPlayer.commandQueue.Enqueue(new CommandInfo(newPlayer.Attack, 0));
            newPlayer.commandQueue.Enqueue(new CommandInfo(newPlayer.Greet, 1));
            newPlayer.commandQueue.Dequeue().Action();
            newPlayer.commandQueue.Enqueue(new CommandInfo(newPlayer.Attack, 0));
            newPlayer.commandQueue.Dequeue().Action();
            newPlayer.commandQueue.Dequeue().Action();

            {
                int index = 0;
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"{++index} 번째 반복, 플레이어 커맨드 추가.");
                    newPlayer.commandQueue.Enqueue(new CommandInfo(newPlayer.Attack, 0));
                }

                index = 0;
                while (newPlayer.commandQueue.Count > 0)
                {
                    Console.Write($"{++index} 번째 반복 : ");
                    newPlayer.commandQueue.Dequeue().Action();
                }
            }
        }
    }

    public class Player
    {
        public P_Action[] playerFunc;
        public P_Action attackFunc;
        public Queue<CommandInfo> commandQueue = new Queue<CommandInfo>();

        public Player()
        {
            playerFunc = new P_Action[2];

            playerFunc[0] = Attack;
            playerFunc[1] = Greet;

            // 이렇게 하는건 굳이인 것 같다. 이렇게 할 이유가 없어보임
            // 괜히 중간 과정만 늘어남. 함수를 바로 호출하는 것에 비해 장점이 없음
            // 오히려 메모리 차지가 더 늘어나며, event 형식을 쓰면 다른 곳에서 Invoke, 초기화 등을 할 수 있는 리스크 존재
            // 이렇게 사용해서 메리트가 있는 경우가 있을지도...
            attackFunc += Attack;
        }

        public void Attack()
        {
            Console.WriteLine("플레이어의 공격");
        }

        public void Greet()
        {
            Console.WriteLine("플레이어의 인사");
        }
    }

    public class CommandInfo
    {
        public P_Action action;
        public int protity;

        public CommandInfo(P_Action action, int protity)
        {
            this.action = action;
            this.protity = protity;
        }

        public void Action()
        {
            action.Invoke();
        }
    }
}
