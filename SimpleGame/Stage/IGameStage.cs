using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Stage
{
    internal interface IGameStage
    {
        int MaxX { get; set; }
        int MaxY { get; set; }
        // 0 : 공백, 1 : 벽
        int[,] ArrMap { get; set; }
    }
}
