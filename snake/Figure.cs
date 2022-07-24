﻿using System;
namespace snake
{
    class Figure
        {
            protected List<Point> pList;

            public virtual void Draw()
            {
                foreach(Point p in pList)
                {
                    p.Draw();
                }
            }
        }
}

