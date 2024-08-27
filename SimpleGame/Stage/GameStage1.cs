using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Stage
{
    internal class GameStage1 : SimpleGame.Stage.IGameStage
    {
        public int MaxX { get; set; } = 5;
        public int MaxY { get; set; } = 5;
        // 0 : 공백, 1 : 벽
        public int[,] ArrMap { get; set; } = {
                    {0,0,0,0,1},
                    {0,0,0,0,1},
                    {0,0,0,0,1},
                    {0,0,0,0,1},
                    {0,0,0,0,1}
        };
    }
}
