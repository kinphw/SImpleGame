using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Main
{
    // 규칙 : 게임에서 사용하는 Class는 GameXX로 선언
    
    // 중재자 패턴을 사용하기 위한 GameMain 클래스 선언
    // 다른 모든 클래스는 여기서 참조
    // 다른 클래스 상호간에 사용하기 위해서는 GameMain을 거침
    internal class GameMain //Game Main
    {
        //////////////////////////////////////////////////
        /// 선언부
        //////////////////////////////////////////////////

        public SimpleGame.Forms.GameForm ObjGameForm { get; set; }        
        public Map.GameMap ObjGameMap { get; set;}
        public SimpleGame.Character.GameCharacterMe ObjGameCharacterMe { get; set; }        
        public SimpleGame.Common.GameConst ObjGameConst { get; set; }

        //////////////////////////////////////////////////
        /// 정의부
        //////////////////////////////////////////////////

        public GameMain(SimpleGame.Forms.GameForm gameForm)
        {
            this.ObjGameForm= gameForm; // 의존성 주입
            this.ObjGameConst = new SimpleGame.Common.GameConst(this);
            ObjGameConst.Set();
        }
        public void MainRun(object sender, EventArgs e)        
        {
            //////////////////////////////////////////////
            /// Stage 1
            //////////////////////////////////////////////
            
            //Map Setting
            SimpleGame.Stage.IGameStage objGameStage1 = new SimpleGame.Stage.GameStage1();
            ObjGameMap = new Map.GameMap(this, objGameStage1);

            //Character Setting
            ObjGameCharacterMe = new Character.GameCharacterMe(this);

            //화면 세팅
            int x = ObjGameMap.MaxX * ObjGameConst.ConstTileSize;
            int y = ObjGameMap.MaxY * ObjGameConst.ConstTileSize + ObjGameConst.ConstMenuHeight;
            ObjGameForm.ClientSize = new Size(x, y);

            

            //Invalidate
            ObjGameForm.Invalidate();
        }
    }
}
