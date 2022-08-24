namespace Grabland
{
    public partial class Form1 : Form
    {

        Graphics m_picture;
        int Row = 5;
        int colums = 7;

        int selectcolor = 1;
        List<GameAlgorithm> listGA  ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("！！！！！！爸爸祝女儿EVA生日快乐！！！！！");
            //pcCanvs.Height = Row + 2 * Row;
            //pcCanvs.Width = colums + 2 * Row;
        }       

        private void addbutton()
        {
           
            Button[] bnt = new Button[Row* colums];
            listGA = new List<GameAlgorithm>();
            GameAlgorithm[] gameAlgorithm = new GameAlgorithm[Row * colums];

            int rw = 0;
            int col = 0;
            for (int i = 0; i < bnt.Length; i++)
            {               
                rw = i / colums;
                col = i % colums;
                //实例化
                gameAlgorithm[i] = new GameAlgorithm();
                gameAlgorithm[i].Value = 0;
                gameAlgorithm[i].Row = rw;
                gameAlgorithm[i].Colum = col;
                gameAlgorithm[i].Number = i;
                gameAlgorithm[i].Btname = "bntton_" + rw + "_" + col.ToString();
                listGA.Add(gameAlgorithm[i]);

                //实例化
                bnt[i] = new Button();
                //定义控件名称
                bnt[i].Name = "bntton_" + rw + "_"+ col.ToString();                
                //定义text属性，可以用string数组初始化为指定值
                bnt[i].Text = i.ToString();
                //注：如果不指定父容器，则坐标是相对于主窗体的
                if (listGA[i].Value == 1)
                {
                    bnt[i].BackColor = Color.Red;
                }
                else if(listGA[i].Value == 2)
                {
                    bnt[i].BackColor = Color.Green;
                }
                bnt[i].Parent = groupBox1;
                //定义坐标
                bnt[i].Location = new Point(50 + (i % colums) * 50, 20 + (i / colums) * 50);
                //调整大小
                //bnt[i].AutoSize = true;
                bnt[i].Size = new Size(50,50);
                //批量添加事件
                bnt[i].Click += new EventHandler(ButtonClick_butten);
            }
        }
        public int? value1 = null;
        public int? value2 = null;
        void ButtonClick_butten(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //实例化按钮，从而获取当前单击按钮的值
            if (value1 == null)
            {
                value1 = Convert.ToInt32(btn.Text);
            }
            int nowcolor = 0;
           

            GameAlgorithm gal = new GameAlgorithm();
            int index = gal.btnameToNumber(listGA, btn.Name);
            int bt_colorvalue = listGA[index].Value;
            if(bt_colorvalue == 0)
            {                
                if (rb_red.Checked)
                {
                    nowcolor = 1;
                    btn.BackColor = Color.Red;
                    listGA[index].Value = nowcolor;
                }
                else if (rb_green.Checked)
                {
                    nowcolor = 2;
                    btn.BackColor = Color.Green;
                    listGA[index].Value = nowcolor;
                }
                gal.Row = Row;
                gal.Colum = colums;

                //查找上一行，下一行 同一列数值，
                //如果 当前数值-colums 值 小于0，上一行同一列数值不变色，
                chagecolor(gal.btnameup(index, listGA, nowcolor), nowcolor);
                //如果 当前数值+colums 值 大于Row*colums，下一行同一列数值不变色，
                chagecolor(gal.btnamedown(index, listGA, nowcolor), nowcolor);
                //如果当前value为0，改变该数值value 为当前所选颜色。
                //查找左边和右边列数值，
                //如果 当前数值/colums 值等于 colums-1，下一个数值不变色，
                chagecolor(gal.btnameright(index, listGA, nowcolor), nowcolor);
                //如果 当前数值%colums 值等于 0，上一个数值不变色，

                chagecolor(gal.btnameleft(index, listGA, nowcolor), nowcolor);
                //如果当前value为0，改变该数值value 为当前所选颜色。

                //MessageBox.Show(List[index].Row.ToString() + "_" + List[index].Colum.ToString() + "_" + List[index].Value.ToString());


                if (rb_red.Checked)
                {
                    rb_red.Checked = false;
                    rb_green.Checked = true;
                }
                else
                {
                    rb_red.Checked = true;
                    rb_green.Checked = false;
                }
            }
            else
            {
                MessageBox.Show("单元不为空，请重新点击！");
            }
            

          
           
        }



        /// <summary>
        /// 根据按键名称改变颜色
        /// </summary>
        /// <param name="btname">按键名称</param>
        private void chagecolor(string btname,int nowcolor)
        {
            foreach (Control item in this.groupBox1.Controls)
            {
                if (item.Name == btname)
                {
                    //item.Visible = true;
                    if (nowcolor == 1)
                    {
                        item.BackColor = Color.Red;
                        //MessageBox.Show(item.Name);
                    }
                    else if(nowcolor == 2)
                    {
                        item.BackColor = Color.Green;
                    }
                }
            }
        }
        private void removerbtname(string btname)
        {
             foreach (Control item in this.groupBox1.Controls)
            {
                if (item.Name == btname)
                {                    
                    this.groupBox1.Controls.Remove(item);
                }
            }
        }


        private void btstart_Click(object sender, EventArgs e)
        {
            //生成游戏的行列内容，并在界面展示按键。
            Row = Convert.ToInt32(tbrow.Text);
            colums = Convert.ToInt32(tbcol.Text);          
            addbutton();
            btstart.Enabled = false;
        }

        private void btreset_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listGA.Count; i++)
            {
                removerbtname(listGA[i].Btname);
            }
            btstart.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_count_Click(object sender, EventArgs e)
        {
           
            int red=0;
            int green=0;
            for( int i = 0; i < listGA.Count; i++)
            {
                if (listGA[i].Value == 1)
                {
                    red = red + 1;
                }
                else if(listGA[i].Value == 2)
                {
                    green = green + 1;
                }
            }

            lbred.Text = "Red:" + red.ToString();
            lb_green.Text = "Green:" + green.ToString();
        }
    }
}