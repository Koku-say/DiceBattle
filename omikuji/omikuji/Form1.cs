namespace omikuji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label4.Visible = false;                 //win,reset,exitbutton���\��
            Resetbutton.Visible = false;
            exitbutton.Visible = false;
        }

        

        int result = 0;
        int goal = 100;
        int sum = 0;
        int a = 0;
        int b = 0;
        int flag=0;
        int[] hozon = new int[1];
        int[] hozon1 = new int[1];
        int i = 0;
        int k=0;
        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int iRnd = rnd.Next(1, 11);

            if (flag > 0)                          //a�̒l��O���[�v��������p���i2�T�ڈȍ~�j
            {
                goal = hozon[a - 1];
                k = hozon1[0];
            }

            if (goal < 0)                       //goal�߂����Ƃ��̏���
            {
                for (i = 1; i <= 10; i++)
                {
                    if (iRnd == i)
                    {
                        goal = goal + iRnd;             //�S�[���܂Ŏc��(�߂�)
                        label1.Text = goal.ToString();  //�S�[���܂Ŏc��\��
                        label2.Text = iRnd.ToString();  //�_�C�X�ł����\��

                        hozon[a] = goal;                   //�S�[���܂ł̒l�ۑ�����
                        flag += flag;                       //          �V
                        a += a;                            //�@�@�@�@�@�V
                        k = k+1;
                        if (k % 2 == 1)
                        {
                            dicebutton.Text = "B���_�C�X�𓊂���";
                            hozon1[0] = k;              //hozon1[0]=k(1)

                        }
                        else if (k % 2 == 0)
                        {
                            dicebutton.Text = "A���_�C�X�𓊂���";
                            hozon1[0] = k;
                        }
                        break;

                    }
                }
            }
            else
            {                                           //goal�߂��ĂȂ��Ƃ�����

                for (i = 1; i <= 10; i++)
                {
                    if (iRnd == i)
                    {
                        goal = goal - iRnd;             //�S�[���܂Ŏc��
                        label1.Text = goal.ToString();  //�S�[���܂Ŏc��\��
                        label2.Text = iRnd.ToString();  //�_�C�X�ł����\��

                        hozon[a] = goal;                   //�S�[���܂ł̒l�ۑ�����
                        flag += flag;                       //          �V
                        a += a;                            //�@�@�@�@�@�V
                        k = k+1;

                        if (k % 2 == 1)
                        {
                            dicebutton.Text = "B���_�C�X�𓊂���";
                            hozon1[0] = k;              //hozon1[0]=k(1)
                        }
                        else if(k % 2 == 0)
                        {
                            dicebutton.Text = "A���_�C�X�𓊂���";
                            hozon1[0] = k;
                        }
                        break;

                    }
                }
            }

            if(label1.Text == "0")
            {
                if(k % 2 == 1)
                {
                    label4.Text = "Player   A\r\n  win!\r\n";
                    label4.Visible = true;
                    Resetbutton.Visible = true;
                    dicebutton.Enabled = false;
                    exitbutton.Visible = true;
                    label3.Text="GOAL!";
                }
                else
                {
                    label4.Text = "Player   B\r\n  win!\r\n";
                    label4.Visible = true;
                    Resetbutton.Visible = true;
                    dicebutton.Enabled = false;
                    exitbutton.Visible = true;
                    label3.Text = "GOAL!";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void Resetbutton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Join.Visible = false;
            button1.Visible = false;    
        }

        private void Join_Click(object sender, EventArgs e)
        {

        }
    }
}
