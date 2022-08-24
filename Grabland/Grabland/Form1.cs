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
            MessageBox.Show("�������������ְ�ףŮ��EVA���տ��֣���������");
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
                //ʵ����
                gameAlgorithm[i] = new GameAlgorithm();
                gameAlgorithm[i].Value = 0;
                gameAlgorithm[i].Row = rw;
                gameAlgorithm[i].Colum = col;
                gameAlgorithm[i].Number = i;
                gameAlgorithm[i].Btname = "bntton_" + rw + "_" + col.ToString();
                listGA.Add(gameAlgorithm[i]);

                //ʵ����
                bnt[i] = new Button();
                //����ؼ�����
                bnt[i].Name = "bntton_" + rw + "_"+ col.ToString();                
                //����text���ԣ�������string�����ʼ��Ϊָ��ֵ
                bnt[i].Text = i.ToString();
                //ע�������ָ������������������������������
                if (listGA[i].Value == 1)
                {
                    bnt[i].BackColor = Color.Red;
                }
                else if(listGA[i].Value == 2)
                {
                    bnt[i].BackColor = Color.Green;
                }
                bnt[i].Parent = groupBox1;
                //��������
                bnt[i].Location = new Point(50 + (i % colums) * 50, 20 + (i / colums) * 50);
                //������С
                //bnt[i].AutoSize = true;
                bnt[i].Size = new Size(50,50);
                //��������¼�
                bnt[i].Click += new EventHandler(ButtonClick_butten);
            }
        }
        public int? value1 = null;
        public int? value2 = null;
        void ButtonClick_butten(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            //ʵ������ť���Ӷ���ȡ��ǰ������ť��ֵ
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

                //������һ�У���һ�� ͬһ����ֵ��
                //��� ��ǰ��ֵ-colums ֵ С��0����һ��ͬһ����ֵ����ɫ��
                chagecolor(gal.btnameup(index, listGA, nowcolor), nowcolor);
                //��� ��ǰ��ֵ+colums ֵ ����Row*colums����һ��ͬһ����ֵ����ɫ��
                chagecolor(gal.btnamedown(index, listGA, nowcolor), nowcolor);
                //�����ǰvalueΪ0���ı����ֵvalue Ϊ��ǰ��ѡ��ɫ��
                //������ߺ��ұ�����ֵ��
                //��� ��ǰ��ֵ/colums ֵ���� colums-1����һ����ֵ����ɫ��
                chagecolor(gal.btnameright(index, listGA, nowcolor), nowcolor);
                //��� ��ǰ��ֵ%colums ֵ���� 0����һ����ֵ����ɫ��

                chagecolor(gal.btnameleft(index, listGA, nowcolor), nowcolor);
                //�����ǰvalueΪ0���ı����ֵvalue Ϊ��ǰ��ѡ��ɫ��

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
                MessageBox.Show("��Ԫ��Ϊ�գ������µ����");
            }
            

          
           
        }



        /// <summary>
        /// ���ݰ������Ƹı���ɫ
        /// </summary>
        /// <param name="btname">��������</param>
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
            //������Ϸ���������ݣ����ڽ���չʾ������
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