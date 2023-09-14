using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class TScreen
{
    List<List<TBLOCK>> BlockList = new List<List<TBLOCK>>();

    public void SetBlock(int _y, int _x, TBLOCK _Type)
    {
        BlockList[_y][_x] = _Type;
    }

    public void Render()
    {
        for (int y = 0; y < BlockList.Count; y++)
        {
            for (int x = 0; x < BlockList[y].Count; x++)
            {
                switch (BlockList[y][x])
                {
                    case TBLOCK.WALL:
                        Console.Write("▣");
                        break;
                    case TBLOCK.VOID:
                        Console.Write("□");
                        break;
                    case TBLOCK.BLOCK:
                        Console.Write("■");
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine();
        }
    }

    public TScreen(int _X, int _Y)
    {
        // 0, 0 같은걸 넣어주면?

        for (int y = 0; y < _Y; y++)
        {
            BlockList.Add(new List<TBLOCK>());
            for (int x = 0; x < _X; x++)
            {
                BlockList[y].Add(TBLOCK.VOID);
            }
        }

        for (int i = 0; i < BlockList[0].Count; i++)
        {
            BlockList[0][i] = TBLOCK.WALL;
        }

        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
        {
            BlockList[BlockList.Count - 1][i] = TBLOCK.WALL;
        }
    }
}
