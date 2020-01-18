using System;
using System.Collections.Generic;
using System.Text;
using Lab4_5_Figure_Factory.Factory;

namespace Lab4_5_Figure_Factory.Class
{
    class Figure
    {
        enum dict
        {
            CreateSquare = 0,
            CreateRectangle = 1,
            CreateCircle = 2
        }
        Dictionary<dict, dynamic> FabricDictionary = new Dictionary<dict, dynamic>()
        {
            { dict.CreateSquare, new SquareFactory()},
            { dict.CreateRectangle, new RectangleFactory()},
            { dict.CreateCircle, new CircleFactory()}
        };
    }
}
