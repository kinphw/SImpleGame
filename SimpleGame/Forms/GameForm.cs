using SimpleGame.Main;
using SimpleGame.Map;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace SimpleGame.Forms
{
    public partial class GameForm : Form
    {
        // GameMain, GameMap ��ü�� ������ �����ϱ� ���� ������� ����
        GameMain objGameMain { get; set;}
        GameMap objGameMap { get; set;}
        
        public GameForm()
        {
            InitializeComponent();

            // �ʱ� ����
            //this.Size = new Size(800, 600);

            // Title ����
            this.Text = "Simple Game";

            // ������ ����, 16x16 8��Ʈ ���������� �����ϰ� �����Ѵ�.
            //this.Icon = new Icon("Icon1.ico", new Size(16, 16));

            // ���ҽ��� �ִ� �������� �о ������ ����
            this.Icon = Properties.Resource.MainIcon;

            // ���� ���۸� ����
            this.DoubleBuffered = true;

            // Form�� ��Ÿ�� �� MainRun() ȣ��
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
            // ���� ������ ������ �Ŀ� ������ �ٽ� �׸���
            this.Invalidate();            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // �ٷ� �ٸ� �Լ��� �״�� ����
            objGameMain.ObjGameCharacterMe.KeyDownEventHandler(sender, e);
            
            //// PictureBox�� ���� ��ġ ��������
            //Point p = pictureBox1.Location;
            //int x = p.X;
            //int y = p.Y;

            //const int MOVE = 50;

            ////Ű���� �Է¿� ���� PictureBox1�� ��ġ�� ����
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

            //// ���� x�� y�� 0���� ������ 0���� ����
            //if (x < 0) x = 0;
            //if (y < 0) y = 0;

            //// ���� x �Ǵ� y�� Form�� ũ�⸦ �Ѿ�� Form�� ũ��� ����
            //if (x > this.ClientSize.Width - pictureBox1.Width) x = this.ClientSize.Width - pictureBox1.Width;
            //if (y > this.ClientSize.Height - pictureBox1.Height) y = this.ClientSize.Height - pictureBox1.Height;

            //pictureBox1.Location = new Point(x, y);            

        }


        // ...

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("ũ����1");
        }


        private void pictureBox1_DoubleClick_1(object sender, EventArgs e)
        {
            MessageBox.Show("ũ����2");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����ؿ� �ǿ��");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            objGameMain.ObjGameMap.DrawMap(e.Graphics);
            objGameMain.ObjGameCharacterMe.DrawCharacterMe(e.Graphics);
        }
    }
}
