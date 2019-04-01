﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 坐标
public class Point
{
    public int x;
    public int z;

    public Point()
    {
        x = z = 0;
    }

    public Point(int x, int z)
    {
        this.x = x;
        this.z = z;
    }
}
