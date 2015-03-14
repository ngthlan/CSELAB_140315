using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSELABMAN.VIEW
{
    public partial class DETAIL : Form
    {
        public DETAIL()
        {
            InitializeComponent();
            //richText_Stt.SelectionAlignment = 
            start();
        }

        public void start()
        {
            richText_Stt.Text = " Phòng Thí nghiệm Kĩ Thuật Máy Tính (PTN KTMT) là phòng chứa rất nhiều thiết bị," +
                                "board mạch cho các hoạt động giảng dạy, học tập của các giảng viên," +
                                " sinh viên ngành Kĩ Thuật Máy Tính, khoa KHOA HỌC VÀ KĨ THUẬT MÁY TÍNH\n";
            richText_Stt.Text += "\n Phòng hiện có các kit thực hành cho các môn cơ sở và chuyên ngành, được tài trợ bởi các tập đoàn," +
                                "công ty về thiết bị điện tử, tin học trên thế giới như : Renasas, Microchip, Altera, Terasic,….\n";
            richText_Stt.Text += "\n Phần mềm \"QUẢN LÝ THẺ RFID - PHÒNG THÍ NGHIỆM KỸ THUẬT MÁY TÍNH\" là một phần của hệ thống “Quản Lí Phòng Thí Nghiệm Kĩ Thuật Máy Tính”" +
                                "thực hiện các chức năng liên quan tới thẻ RFID của các người dùng, thiết bị nhằm quản lí tốt hơn";
        }

        private void button_Intro_Click(object sender, EventArgs e)
        {
            start();
        }

        private void button_DetFunc_Click(object sender, EventArgs e)
        {
            richText_Stt.Text = "A. Quản lý người dùng, đối tượng quản lý là các giảng viên, sinh viên tham gia sử dụng PTN. " +
                                "với 2 tác vụ sau :" +
                                "\n  + Đăng kí thẻ người dùng mới" +
                                "\n  + Chỉnh sửa thông tin thẻ \n" +
                                "\nB. Quản lý thiết bị, đối tượng quản lý là các thiết bị, linh kiện được nhập từ các công ty về CNTT " +
                                "tham gia phục quá trình dạy và học của giảng viên, sinh viên ngành KTMT, với 2 tác vụ sau :" +
                                "\n  + Đăng kí thẻ thiết bị mới " +
                                "\n  + Chỉnh sửa thông tin thẻ \n" + 
                                "\nC. Quản lý mượn/trả thiết bị, cho phép theo dõi quá trình mượn/trả thiết bị của các giảng viên, sinh viên"
                                +" trong quá trình học tập và làm việc tại phòng.";
        }

        private void button_Ver_Click(object sender, EventArgs e)
        {
            richText_Stt.Text = "\n Sơ lược : Đây là đề tài LVTN HK142, được áp dụng thí điểm tại phòng thí nghiệm KTMT khi đang trong thời gian hiện thực và hoàn thiện"+
                                "\n\n Phiên bản : Version 1.1.0.0"+
                                "\n\n Tác giả : Nguyễn Thế Lân - Nguyễn Lê Khôi"+
                                "\n\n Bản quyền thuộc về bộ môn KĨ THUẬT MÁY TÍNH, khoa KHOA HỌC VÀ KĨ THUẬT MÁY TÍNH, trường Đại học Bách Khoa TPHCM"+
                                "\n\n \t \tCopyright by \u00a9 NTL 2015";
        }
    }
}
