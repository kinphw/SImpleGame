using SimpleGame.Main;
using SimpleGame.Map;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SimpleGame.Forms
{
    public partial class GameForm : Form
    {
        // GameMain, GameMap 객체를 의존성 주입하기 위한 멤버변수 선언
        GameMain objGameMain { get; set;}
        GameMap objGameMap { get; set;}
        
        public GameForm()
        {
            InitializeComponent();

            // 초기 세팅
            //this.Size = new Size(800, 600);

            // Title 설정
            this.Text = "Simple Game";

            // 아이콘 설정, 16x16 8비트 아이콘으로 설정하게 구현한다.
            //this.Icon = new Icon("Icon1.ico", new Size(16, 16));

            // 리소스에 있는 아이콘을 읽어서 아이콘 설정
            this.Icon = Properties.Resource.MainIcon;

            // 더블 버퍼링 설정
            this.DoubleBuffered = true;

            // Form이 나타난 후 MainRun() 호출
            objGameMain = new SimpleGame.Main.GameMain(this);            
            this.Shown += new EventHandler(objGameMain.MainRun);



        }
        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        CreateParams cp = base.CreateParams;
        //        cp.ExStyle = 0x02000000;
        //        return cp;
        //    }
        //}

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            // 폼이 완전히 보여진 후에 강제로 다시 그리기
            this.Invalidate();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // 바로 다른 함수로 그대로 전달
            objGameMain.ObjGameCharacterMe.KeyDownEventHandler(sender, e);
            
            //// PictureBox의 현재 위치 가져오기
            //Point p = pictureBox1.Location;
            //int x = p.X;
            //int y = p.Y;

            //const int MOVE = 50;

            ////키보드 입력에 따라 PictureBox1의 위치를 변경
            //if (e.KeyCode == Keys.Left)
            //{
            //    x -= MOVE;
            //}
            //else if (e.KeyCode == Keys.Right)
            //{
            //    x += MOVE;
            //}
            //else if (e.KeyCode == Keys.Up)
            //{
            //    y -= MOVE;
            //}
            //else if (e.KeyCode == Keys.Down)
            //{
            //    y += MOVE;
            //}

            //// 만약 x나 y가 0보다 작으면 0으로 변경
            //if (x < 0) x = 0;
            //if (y < 0) y = 0;

            //// 만약 x 또는 y가 Form의 크기를 넘어가면 Form의 크기로 변경
            //if (x > this.ClientSize.Width - pictureBox1.Width) x = this.ClientSize.Width - pictureBox1.Width;
            //if (y > this.ClientSize.Height - pictureBox1.Height) y = this.ClientSize.Height - pictureBox1.Height;

            //pictureBox1.Location = new Point(x, y);            

        }


        // ...

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("크헤헤1");
        }


        private void pictureBox1_DoubleClick_1(object sender, EventArgs e)
        {
            MessageBox.Show("크헤헤2");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("사랑해요 건우맨");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            objGameMain.ObjGameMap.DrawMap(e.Graphics);
            objGameMain.ObjGameCharacterMe.DrawCharacterMe(e.Graphics);
        }
    }
}
