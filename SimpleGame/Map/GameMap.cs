using SimpleGame.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Map
{
    internal class GameMap // 여러가지 맵 인스턴스 생성 상정하여 동적으로 개발
    {
        GameMain objGameMain { get; set;}
        int ConstTileSize;
        int[,] arrMap;

        Image imgBlank;
        Image imgWall;
        Image imgNyang;

        int intMenuHeight;

        public int MaxX;
        public int MaxY;

        // 생성자 구현
        public GameMap(GameMain objGameMain, SimpleGame.Stage.IGameStage objGameStage)
        {
            this.objGameMain = objGameMain;
            ConstTileSize = objGameMain.ObjGameConst.ConstTileSize;

            this.MaxX = objGameStage.MaxX;
            this.MaxY = objGameStage.MaxY;
            this.arrMap = objGameStage.ArrMap;
                       
            // 0 : 공백, 1 : 벽
            //arrMap = new int[,]
            //{
            //    {0,0,0,0,1},
            //    {0,0,0,0,1},
            //    {0,0,0,0,1},
            //    {0,0,0,0,1},
            //    {0,0,0,0,1}
            //};

            // 리소스 미리 로드
            imgBlank = Properties.Resource.Blank;
            imgWall = Properties.Resource.Wall;
            imgNyang = Properties.Resource.냥코;

            // 기초 세팅
            intMenuHeight = this.objGameMain.ObjGameForm.MenuStrip1.Height;
        }

        // 배열을 인수로 받아서, arrMap에서 해당하는 값을 int로 반환하는 getter 구현
        public int GetMap(int x, int y)
        {
            return arrMap[y, x]; // x, y는 2, 1
        }

        // DrawMap() 구현
        public void DrawMap(Graphics g)
        {            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arrMap[i, j] == 0)
                    {
                        g.DrawImage(imgBlank, j * ConstTileSize, i * ConstTileSize + intMenuHeight, ConstTileSize, ConstTileSize);
                        // 검은 사각형을 그림
                        //g.DrawRectangle(new Pen(Color.Black), j * ConstTileSize, i * ConstTileSize, ConstTileSize, ConstTileSize);

                    } else if (arrMap[i, j] == 1)
                    {
                        g.DrawImage(imgWall, j * ConstTileSize, i * ConstTileSize + intMenuHeight, ConstTileSize, ConstTileSize);
                    }
                }
            }

            // g.DrawImage(imgNyang, 200, 200 + intMenuHeight, ConstTileSize, ConstTileSize);
        }
    }
}
