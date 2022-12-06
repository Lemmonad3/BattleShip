using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BattleShip
{
   public class SeaBattle
    {

        public SeaBattle()
        {
            for (int i = 0; i < _see.Count(); i++)
            {
                _see[i] = new int[10];
                _seeEnemy[i] = new int[10];
                for(int j = 0; j < _see[i].Count(); j++)
                {
                    _see[i][j] = 0;
                    _seeEnemy[i][j] = 0;
                }
                
            }
            _vertical = true;
        }

        public void WatchShip(int y, int x, int w, int h, int size, Panel panelbattle)
        {
            NullMas();
            CreateShip(x, y, 1, size - 1, _see);
            for (int i = 0; i < _see.Count(); i++)
                for (int j = 0; j < _see[i].Count(); j++)
                    if (Rendering(x, y, i, j, size - 1)) { panelbattle.Invalidate(new Rectangle(i * w, j * h, w, h)); }   
        }

        public void NullMas()
        {
            for (int i = 0; i < _see.Count(); i++)
                for (int j = 0; j < _see[i].Count(); j++)
                    if (_see[i][j] != 2)
                        _see[i][j] = 0;
                    
        }

        public void CreateShip(int x, int y, int value, int size, int[][] mas)
        {
            int dopPoint = mas.Count() - 1 - y - size;
            if (dopPoint > 0) dopPoint = 0;
            int iMinLimitV = 0 + dopPoint;
            int IMaxLimitV = 1 + size;
            if (_vertical)
                for (int i = iMinLimitV; i < IMaxLimitV; i++)
                    if (y + i >= 0 && y + i < 10)
                        if (mas[y + i][x] != 2)
                            mas[y + i][x] = value;
                dopPoint = mas.Count() - 1 - x - size;           
            if (dopPoint > 0) dopPoint = 0;
            int jMinLimitH = 0 + dopPoint;
            int jMaxLimitH = 1 + size;
            if (!_vertical)
                for (int j = jMinLimitH; j < jMaxLimitH; j++)
                    if (x + j >= 0 && x + j < 10)
                        if (mas[y][x + j] != 2)
                            mas[y][x + j] = value;
        }

        public bool Rendering(int x, int y, int i, int j, int size)
        {
            int dopPoint = 9 - y - size;
            if (dopPoint > 0) dopPoint = 0;
            int uMinLimitV = -1 + dopPoint;
            int uMaxLimitV = 2 + size;
            if (_vertical)
                for (int u = uMinLimitV; u < uMaxLimitV; u++)
                    for (int z = -1; z < 2; z++)
                        if (y + u >= 0 && y + u < 10 && x + z >= 0 && x + z < 10)
                            if (y + u == j && z + x == i)
                                return true;
                dopPoint = 9 - x - size;
            if (dopPoint > 0) dopPoint = 0;
            int zMinLimitV = -1 + dopPoint;
            int zMaxLimitV = 2 + size;
            if (!_vertical)
                for (int u = -1; u < 2; u++)
                    for (int z = zMinLimitV; z < zMaxLimitV; z++)
                        if (y + u >= 0 && y + u < 10 && x + z >= 0 && x + z < 10)
                            if (y + u == j && z + x == i)
                                return true;
            return false;

        }

        public bool CheckSq(int x, int y, int size, int[][] mas)
        {
            int dopPoint = mas.Count() - 1 - y - size;
            if (dopPoint > 0) dopPoint = 0;
            int iMinLimitV = -1 + dopPoint;
            int iMaxLimitV = 2 + size;
            if (_vertical)
                for (int i = iMinLimitV; i < iMaxLimitV; i++)
                    for (int j = -1; j < 2; j++)
                        if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10)
                            if (mas[y + i][x + j] > 0)
                                return false;
                dopPoint = mas.Count() - 1 - x - size;
            if (dopPoint > 0) dopPoint = 0;
            int jMinLimitH = -1 + dopPoint;
            int jMaxLimitH = 2 + size;
            if (!_vertical)
                 for (int i = -1; i < 2; i++)
                    for (int j = jMinLimitH; j < jMaxLimitH; j++)
                        if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10)
                            if (mas[y + i][x + j] > 0)
                                return false;
            return true;

        }

        public void Explosion(int x, int y, int[][] mas)
        {
            int size = 0;
            bool flag = true; 
            int bufI = y, bufJ = x;

            while (bufI > 0 && (mas[bufI - 1][bufJ] == 3 || mas[bufI - 1][bufJ] == 2))
            {
                bufI--;
                size++;
                if (bufI >= 0 && mas[bufI][bufJ] == 2) flag = false;
            }
            bufI = y; bufJ = x;

            while (bufI < 9 && (mas[bufI + 1][bufJ] == 3 || mas[bufI + 1][bufJ] == 2))
            {
                bufI++;
                size++;
                if (bufI < 10 && mas[bufI][bufJ] == 2) flag = false;
            }
            bufI = y; bufJ = x;

            while (bufJ > 0 && (mas[bufI][bufJ - 1] == 3 || mas[bufI][bufJ - 1] == 2))
            {
                bufJ--;
                size++;
                if (bufJ >= 0 && mas[bufI][bufJ] == 2) flag = false;
            }
            bufI = y; bufJ = x;

            while (bufJ < 9 && (mas[bufI][bufJ + 1] == 3 || mas[bufI][bufJ + 1] == 2))
            {
                bufJ++;
                size++;
                if (bufJ < 10 && mas[bufI][bufJ] == 2) flag = false;
            }

            if (flag)
            {
                bool vert;
                while (y > 0 && mas[y - 1][x] == 3) y--;
                while (x > 0 && mas[y][x - 1] == 3) x--;

                if (y < 9 && mas[y + 1][x] == 3) vert = true;
                else vert = false;
                if (vert)
                    for (int i = -1; i < 2 + size; i++)
                        for (int j = -1; j < 2; j++)
                            if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10 && mas[y + i][x + j] != 3)
                                mas[y + i][x + j] = 4;
                if (!vert)
                    for (int i = -1; i < 2; i++)
                        for (int j = -1; j < 2 + size; j++)
                            if (y + i >= 0 && y + i < 10 && x + j >= 0 && x + j < 10 && mas[y + i][x + j] != 3)
                                mas[y + i][x + j] = 4;
            }
        }

        public int FindNextRb(RadioButton r1, RadioButton r2, RadioButton r3, RadioButton r4)
        {
            if (r1.Enabled)
            {
                r1.Checked = true;
                return 0;
            }
            if (r2.Enabled)
            {
                r2.Checked = true;
                return 0;
            }
            if (r3.Enabled)
            {
                r3.Checked = true;
                return 0;
            }
            if (r4.Enabled)
            {
                r4.Checked = true;
                return 0;
            }
            return 0;
        }
        public void Reset()
        {
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    _see[i][j] = 0;
            _count1x = 0;
            _count2x = 0;
            _count3x = 0;
            _count4x = 0;
        }
        public int this[int index1, int index2]
        {
            get { return _see[index1][index2]; }
            set { _see[index1][index2] = value; }
        }
        public void ChangeVertical()
        {
            if (_vertical) _vertical = false;
            else  _vertical = true;

        }
        public int ReturnMasSize()
        {
            return _see.Count();
        }
        public int [][] GetLink()
        {
            return _see;
        }
        public int[][] GetEnemyLink()
        {
            return _seeEnemy;
        }
        public int GetEnemyValue(int i, int j )
        {
            return _seeEnemy[i][j];
        }
        public void SetEnemyValue(int i, int j, int value)
        {
             _seeEnemy[i][j] = value;
        }

        public int Count1X
        {
            get { return _count1x; }
            set { _count1x = value; }
        }
        public int Count2X
        {
            get { return _count2x; }
            set { _count2x = value; }
        }
        public int Count3X
        {
            get { return _count3x; }
            set { _count3x = value; }
        }
        public int Count4X
        {
            get { return _count4x; }
            set { _count4x = value; }
        }
        public int MyShip
        {
            get { return _myShip; }
            set { _myShip = value; }
        }
        public int EnemyShip
        {
            get { return _enemyShip; }
            set { _enemyShip = value; }
        }


        private int[][] _see = new int[10][];
        private int[][] _seeEnemy = new int[10][];
        private bool _vertical;
        private int _count1x;
        private int _count2x;
        private int _count3x;
        private int _count4x;
        private int _myShip = 20;
        private int _enemyShip = 20;

    }
}
