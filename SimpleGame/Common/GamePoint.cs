using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame.Common
{
    internal class GamePoint
    {
        int _x; // x축 = 2차배열
        int _y; // y축 = 1차배열
        int _arr1; // 1차배열 = y축
        int _arr2; // 2차배열 = x축
        
        public int X {
            get { return _x; }
            set {
                _x = _arr2 =value;
            }
        } //X축 : 2차배열
        public int Y { 
            get {
                return _y;
            }
            set
            {
                _y = _arr1 = value;
            }
        } //Y축 : 1차배열

        public int Arr1 { 
            get
            {  return _arr1; }
            set
            {
                _arr1 = _y = value;
            }
        }
        public int Arr2
        {
            get
            { return _arr2; }
            set
            {
                _arr2 = _x = value;
            }
        }

        public GamePoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
