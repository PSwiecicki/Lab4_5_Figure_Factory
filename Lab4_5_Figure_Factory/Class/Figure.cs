using System;
using System.Collections.Generic;
using System.Text;
using Lab4_5_Figure_Factory.Factory;

namespace Lab4_5_Figure_Factory.Class
{
    class Figure
    {

        Dictionary<Dict, dynamic> FabricDictionary = new Dictionary<Dict, dynamic>()
        {
            { Dict.CreateSquare, new SquareFactory()},
            { Dict.CreateRectangle, new RectangleFactory()},
            { Dict.CreateCircle, new CircleFactory()}
        };

        public IFigure Create(Dict a)
        {
            return FabricDictionary[a].Create();
        }
    }

    public enum Dict
    {
        CreateSquare,
        CreateRectangle,
        CreateCircle
    }
}
