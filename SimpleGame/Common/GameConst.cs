using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Common
{
    internal class GameConst
    {
        // 변경될 수 있는 상수를 여기에 일괄 정의
        public int ConstTileSize { get; set; } = 50;
        public int ConstMenuHeight { get; set; }

        SimpleGame.Main.GameMain objGameMain;

        public GameConst(SimpleGame.Main.GameMain objGameMain)
        {
            this.objGameMain = objGameMain;            
        }

        public void Set()
        {
            ConstMenuHeight = this.objGameMain.ObjGameForm.MenuStrip1.Height;
        }

    }
}
