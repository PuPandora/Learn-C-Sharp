﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Item
{
    string mName;
    int mGold;

    // 시작부터 쓸거라고 예상하고 만드는건
    // 좋지 않은 습관.. (프로그래밍이 익숙한게 아니라면)
    public string Name
    {
        get
        {
            return mName;
        }
        set
        {
            mName = value;
        }
    }

    public int Gold
    {
        get
        {
            return mGold;
        }
        set
        {
            mGold = value;
        }
    }

    public Item(string _Name, int _Gold)
    {
        Name = _Name;
        Gold = _Gold;
    }
}
