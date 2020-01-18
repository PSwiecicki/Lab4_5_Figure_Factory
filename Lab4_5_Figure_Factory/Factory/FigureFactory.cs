using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4_5_Figure_Factory.Factory
{
    abstract class FigureFactory
    {
        public abstract IFigure Create();
    }
}
