using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Timers;

using SimpleGame.Common;
namespace SimpleGame.Character
{
    
    internal class GameCharacterMe
    {
        SimpleGame.Main.GameMain objGameMain { get; set; }
        SimpleGame.Common.GamePoint ptMe { get; set; }

        Image imgCharacterMe { get; set;}

        // 생성자 구현
        public GameCharacterMe(SimpleGame.Main.GameMain objGameMain)
        {
            this.objGameMain = objGameMain;
            ptMe = new GamePoint(0, 0);
            imgCharacterMe = Properties.Resource.냥코;
        }

        public void DrawCharacterMe(Graphics g)
        {
            int x = ptMe.X * objGameMain.ObjGameConst.ConstTileSize;
            int y = ptMe.Y * objGameMain.ObjGameConst.ConstTileSize + objGameMain.ObjGameConst.ConstMenuHeight;
            int xWidth = objGameMain.ObjGameConst.ConstTileSize;
            int yHeight = objGameMain.ObjGameConst.ConstTileSize;

            g.DrawImage(imgCharacterMe, x, y, xWidth, yHeight);
        }

        public void MoveCharacterMe(int x, int y)
        {
            ptMe.X = x;
            ptMe.Y = y;
        }


        public void KeyDownEventHandler(object sender, KeyEventArgs e)
        {
            // PictureBox의 현재 위치 가져오기            
            int x = ptMe.X;
            int y = ptMe.Y;            

            //키보드 입력에 따라 PictureBox1의 위치를 변경
            if (e.KeyCode == Keys.Left)
            {
                x -= 1;
            }
            else if (e.KeyCode == Keys.Right)
            {
                x += 1;
            }
            else if (e.KeyCode == Keys.Up)
            {
                y -= 1;
            }
            else if (e.KeyCode == Keys.Down)
            {
                y += 1;
            }

            // 만약 x나 y가 0보다 작으면 0으로 변경
            if (x < 0) x = 0;
            if (y < 0) y = 0;

            // 만약 x 또는 y가 Form의 크기를 넘어가면 Form의 크기로 변경
            if (x > this.objGameMain.ObjGameMap.MaxX-1) x = this.objGameMain.ObjGameMap.MaxX-1;
            if (y > this.objGameMain.ObjGameMap.MaxY-1) y = this.objGameMain.ObjGameMap.MaxY-1;

            MoveCharacterMe(x, y);
            this.objGameMain.ObjGameForm.Invalidate();
        }



    }
}
