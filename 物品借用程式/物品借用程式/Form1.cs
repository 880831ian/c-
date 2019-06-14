using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace 物品借用程式
{
    public partial class Form1 : Form
    {
        int a;  
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_send_ck_Click(object sender, EventArgs e)
        {      
            DialogResult Result = MessageBox.Show("現在時間:"+ "\r\n系級： " + cbox_company.Text+ "\r\n學號： "+tbox_stuid.Text+ "\r\n姓名： " + tbox_name.Text+ "\r\n電話： " + tbox_phone.Text+ "\r\n信箱： " + tbox_mail.Text+ "\r\n借用物品： " + cbox_ltem.Text+ "\r\n數量： " + tbox_num.Text+ "\r\n借出日期： " + DateTime.Now.ToShortDateString()+ "\r\n預計歸還日期： " + dateTime1.Text+ "\r\n借出人： " + cbox_lend_name.Text, "請確認借用物品資料是否正確", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (Result == DialogResult.OK)
                {
                    MessageBox.Show("***系統將會自動傳送借用物品確認信件到<" + tbox_mail.Text + ">，請勿回覆***\n並請在預計歸還時間內，歸還物品，朝陽學生會感謝您!", "系統提示");
                    try
                    {
                        System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
                        msg.To.Add(tbox_mail.Text);
                        //msg.To.Add("b@b.com");可以發送給多人
                        //msg.CC.Add("c@c.com");
                        //msg.CC.Add("c@c.com");可以抄送副本給多人 
                        //這裡可以隨便填，不是很重要
                        msg.From = new MailAddress("cyutsg@gmail.com", "朝陽學生會", System.Text.Encoding.UTF8);
                        /* 上面3個參數分別是發件人地址（可以隨便寫），發件人姓名，編碼*/
                        msg.Subject = "朝陽學生會 [借用物品確認信件] ";//郵件標題
                        msg.SubjectEncoding = System.Text.Encoding.UTF8;//郵件標題編碼
                        msg.Body = "***　此為系統自動發出確認信，請勿回信，如有問題，請到學生會網站：www.cyutsg.org ***"+ "<b><br>系級： " + cbox_company.Text + "<br>學號： " + tbox_stuid.Text + "<br>姓名： " + tbox_name.Text + "<br>電話： " + tbox_phone.Text + "<br>信箱： " + tbox_mail.Text + "<br>借用物品： " + cbox_ltem.Text + "<br>數量： " + tbox_num.Text + "<br>借出日期： " + DateTime.Now.ToShortDateString()+ "<br><font color='red'>預計歸還日期： " + dateTime1.Text + "</font><br>借出人： " + cbox_lend_name.Text + "</b><br>***　此為系統自動發出確認信，請勿回信，如有問題，請到學生會網站：www.cyutsg.org ***"; //郵件內容
                        msg.BodyEncoding = System.Text.Encoding.UTF8;//郵件內容編碼 
                                                                     //msg.Attachments.Add(new Attachment(@"D:\test2.docx"));  //附件
                        msg.IsBodyHtml = true;//是否是HTML郵件 
                                              //msg.Priority = MailPriority.High;//郵件優先級 

                        SmtpClient client = new SmtpClient();
                        client.Credentials = new System.Net.NetworkCredential("cyutsg@gmail.com", "cyutsg25th"); //這裡要填正確的帳號跟密碼
                        client.Host = "smtp.gmail.com"; //設定smtp Server
                        client.Port = 25; //設定Port
                        client.EnableSsl = true; //gmail預設開啟驗證
                        client.Send(msg); //寄出信件
                        client.Dispose();
                        msg.Dispose();
                        MessageBox.Show(this, "郵件寄送成功！");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message);
                    }
                var lvi = new ListViewItem(cbox_company.Text);

                lvi.SubItems.Add(tbox_stuid.Text);
                lvi.SubItems.Add(tbox_name.Text);
                lvi.SubItems.Add(tbox_phone.Text);
                lvi.SubItems.Add(tbox_mail.Text);
                lvi.SubItems.Add(cbox_ltem.Text);
                lvi.SubItems.Add(tbox_num.Text);
                lvi.SubItems.Add(DateTime.Now.ToLongDateString());
                lvi.SubItems.Add(dateTime1.Text);
                lvi.SubItems.Add(cbox_lend_name.Text);
                lvi.SubItems.Add(cbox_idcard.Text);

                listView1.Items.Add(lvi);

                //cbox_company.Text = "";
                //tbox_stuid.Text = "";
                //tbox_name.Text = "";
                //tbox_phone.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //驗證是否正確填入資料 
            //正確填入資料才可送出
            if (tbox_num.Text == "" || tbox_stuid.Text=="" || tbox_name.Text=="" || tbox_phone.Text =="" || tbox_mail.Text == "" || cbox_ltem.Text == "" || cbox_lend_name.Text=="" )
            {
                button_send_ck.Enabled = false;
            }
            else
            {
                button_send_ck.Enabled = true;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lvi = new ListViewItem(cbox_company.Text);

            lvi.SubItems.Add(tbox_stuid.Text);
            lvi.SubItems.Add(tbox_name.Text);
            lvi.SubItems.Add(tbox_phone.Text);
            lvi.SubItems.Add(tbox_mail.Text);
            lvi.SubItems.Add(cbox_ltem.Text);
            lvi.SubItems.Add(tbox_num.Text);
            lvi.SubItems.Add(DateTime.Now.ToLongDateString());
            lvi.SubItems.Add(dateTime1.Text);
            lvi.SubItems.Add(cbox_lend_name.Text);
            lvi.SubItems.Add(cbox_idcard.Text);

            listView1.Items.Add(lvi);

            //cbox_company.Text = "";
            //tbox_stuid.Text = "";
            //tbox_name.Text = "";
            //tbox_phone.Text = "";

                
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int Index = 0;
            if (this.listView1.SelectedItems.Count > 0)//判断listview有被选中项
            {
                Index = this.listView1.SelectedItems[0].Index;//取当前选中项的index,SelectedItems[0]这必须为0
                listView1.Items[Index].Remove();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*foreach (ListViewItem tmpLstView in listView1.Items)
            {
                if (tmpLstView.Selected == true) //==> 被選取為true
                        {
                    textBox2.Text = listView1.SubItems[1].Text;
                    //strList1 = strList1 + tmpLstView.Text + ",";
                    //strWorkID1 = strWorkID1 + tmpLstView.SubItems[1].Text + ",";
                }
            }*/
        }
    }
}
