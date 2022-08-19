using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grabland
{
    internal class GameAlgorithm
    {
        //public static int [][] arrays;
        private int row;
        private int colum;
        private int number;
        private int value;
        private string btname;

        public GameAlgorithm(int row, int colum, int value)
        {
            this.Row = row;
            this.Colum = colum;
            this.Value = value;
        }
        public GameAlgorithm()
        {
            
        }

        public int Row { get => row; set => row = value; }
        public int Colum { get => colum; set => colum = value; }
        public int Value { get => value; set => this.value = value; }
        public int Number { get => number; set => number = value; }
        public string Btname { get => btname; set => btname = value; }

        public string btnameup(int nownb, List<GameAlgorithm> list, int color)
        {
            //如果 当前数值-colums 值 小于0，上一行同一列数值不变色，
            //如果当前value为0，改变该数值value 为当前所选颜色。
            string name = "";
            int nb = nownb - Colum;
            int serach = 0;
            if(nb>=0)
            {
                
                int clr = list[nb].value;
               
                list[nb].Value = color;
                name = "bntton_" + list[nb].Row.ToString() + "_" + list[nb].Colum.ToString();
                
            }
            return name;
        }
        public string btnamedown( int nownb,List<GameAlgorithm> list, int color)
        {
            //如果 当前数值+colums 值 大于Row*colums，下一行同一列数值不变色，
            //如果当前value为0，改变该数值value 为当前所选颜色。
            string name = "";
            int nb = nownb + Colum;
            if (nb < Row * Colum)
            {
                list[nb].Value = color;
                name = "bntton_" + list[nb].Row.ToString() + "_" + list[nb].Colum.ToString();
            }
            return name;
        }
        public string btnameleft(int nownb, List<GameAlgorithm> list, int color)
        {
            //如果 当前数值%colums 值等于 0，上一个数值不变色，
            //如果当前value为0，改变该数值value 为当前所选颜色。
            string name = "";
            int left = nownb % Colum;
            int nb = -1;
            if (left != 0)
            {
                nb = nownb - 1;
                list[nb].Value = color;
                name = "bntton_" + list[nb].Row.ToString() + "_" + list[nb].Colum.ToString();
            }
            return name;
        }

        public string btnameright( int nownb, List<GameAlgorithm> list, int color)
        {
            //如果 当前数值% colums 值等于 colums-1，下一个数值不变色，
            //如果当前value为0，改变该数值value 为当前所选颜色。
            string name = "";
            int right = nownb % Colum;
            int nb = -1;
            if (right != (Colum-1))
            {
                nb = nownb + 1;
                list[nb].Value = color;
                name = "bntton_" + list[nb].Row.ToString() + "_" + list[nb].Colum.ToString();
            }
            return name;
        }

        public int btnameToNumber(List<GameAlgorithm> list,string bt_name)
        {
            int nb = -1;
           for(int i = 0; i < list.Count; i++)
            {
                if (list[i].btname.Equals(bt_name))
                {
                    nb = i;
                }
            }
           return nb;
        }
    }
}
