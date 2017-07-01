using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private static string user_name = null;
        private static string id = null;
        private string ten_tai_san = "";
        private string ten_cong_ty = "";
        private string loai_tai_san = "";
        private string han_bao_hanh = "";
        private string ngay_trang_bi = "";
        private string gia_tien = "";
        private string gia_tien_thue = "";
        private string ls_ten = null;
        private string ls_congty = null;
        private string ls_tai_san = null;
        private string ls_thoi_gian_bao_hanh = null;
        private string ls_thoi_gian_trang_bi = null;
        private string ls_gia_tien = null;
        private string ls_gia_tien_thue =null;
        private string ls_nguoi_thay_doi = "";
        private string ls_thoi_gian_thay_doi = "";

        public Form1()
        {
            InitializeComponent();
            thoigianbaohanh.Enabled = false;
            thoigiantrangbi.Enabled = false;
            giatien.Enabled = false;
            them.Enabled = false;
            tentaisan.Enabled = false;
            congty.Enabled = false;
            cmLoaitaisan.Enabled = false;
            capnhat.Enabled = false;
            xoa.Enabled = false;
            timkiem.Enabled = false;
           
       
            lichsu.Enabled = false;
            btnDanhsanh.Enabled = false;
            txt_giaitien_thue.Enabled = false;
           // laydanhsachtaisan();

        }
        public void laydanhsachtaisan()
        {
            Connect connect = new Connect();
            DataTable dt = new DataTable();
            dt = connect.laybang("select * from tai_san;");
            tabledata.DataSource = dt;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();

            if(tentaisan.Text==""){
                errorProvider1.SetError(tentaisan, "Nhập tên tài sản");
            }
            if(congty.Text==""){
                errorProvider1.SetError(congty,"Nhập tên công ty");
            }

            string ten = tentaisan.Text;
            string tencongty = congty.Text;
            string loai = cmLoaitaisan.SelectedItem.ToString();

            if (tentaisan.Text != "" && congty.Text != "")
            {
                if (cmLoaitaisan.SelectedItem.ToString() == "Tài sản cố định")
                {
                    if (giatien.Text != "")
                    {
                        if (giatien.Text == "")
                        {
                            errorProvider1.SetError(giatien, "Chưa nhập giá tiền");

                        }
                        else
                        {
                            
                            string baohanh = thoigianbaohanh.Text;
                            string trangbi = thoigiantrangbi.Text;
                           
                            if (baohanh != trangbi)
                            {
                                int status = connect.xulydulieu("insert into tai_san(ten_tai_san,cong_ty_so_huu,loai_tai_san,thoi_gian_bao_hanh,thoi_diem_trang_bi,gia_tien,ten_tai_khoan) values(N'"+ten+"',N'"+tencongty+"',N'"+loai+"','"+baohanh+"','"+trangbi+"','"+giatien.Text+"','"+user_name+"');");
                            if (status > 0)
                            {
                                MessageBox.Show("Thêm tài sản thành công");
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài sản không thành công");
                            }
                            laydanhsachtaisan();
                            }
                            else
                            {
                                MessageBox.Show("vui lòng điền thời gian trang bị và thời gian bảo hành!");
                            }
                            return;
                        }
                        
                    }

                }
                string gia_tien = txt_giaitien_thue.Text;
                MessageBox.Show(gia_tien);
                int status_1 = connect.xulydulieu("insert into tai_san(ten_tai_san,cong_ty_so_huu,loai_tai_san,ten_tai_khoan,gia_tien_thue) values(N'" + ten + "',N'" + tencongty + "',N'" + loai + "','"+user_name+"','"+gia_tien+"');");
                if (status_1 > 0)
                {
                    MessageBox.Show("Thêm tài sản thành công");
                }
                else
                {
                    MessageBox.Show("Thêm tài sản không thành công");
                }
                laydanhsachtaisan();
               }
           
        }

        private void cmLoaitaisan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmLoaitaisan.SelectedItem.ToString() == "Tài sản cố định")
            {
               
                thoigianbaohanh.Enabled = true;
                thoigiantrangbi.Enabled = true;
                giatien.Enabled = true;
                txt_giaitien_thue.Enabled = false;
                them.Enabled = true;
            }
            else if (cmLoaitaisan.SelectedItem.ToString() == "Tài sản cho thuê")
            {
                thoigianbaohanh.Enabled = false;
                thoigiantrangbi.Enabled = false;
                giatien.Enabled = false;
                txt_giaitien_thue.Enabled = true;
                them.Enabled = true;
            }
            else
            {
               
              
                thoigianbaohanh.Enabled = false;
                thoigiantrangbi.Enabled = false;
                giatien.Enabled = false;
                txt_giaitien_thue.Enabled = false;
                them.Enabled = false;
            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn xóa tài sản " + ten_tai_san + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                int kq = connect.xulydulieu("Delete from tai_san where id=N'" + id + "';");
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công!");
                    laydanhsachtaisan();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
           
         

        }

        private void tabledata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = tabledata.Rows[e.RowIndex];
                  id = row.Cells[0].Value.ToString();
                this.ten_tai_san = row.Cells[1].Value.ToString();
                this.ten_cong_ty = row.Cells[2].Value.ToString();
                this.loai_tai_san = row.Cells[3].Value.ToString();
                this.han_bao_hanh = row.Cells[4].Value.ToString();
                this.ngay_trang_bi = row.Cells[5].Value.ToString();
                this.gia_tien = row.Cells[6].Value.ToString();
                this.gia_tien_thue = row.Cells[8].Value.ToString();
                tentaisan.Text = this.ten_tai_san;
                congty.Text = this.ten_cong_ty;
                cmLoaitaisan.Text = this.loai_tai_san;
                xoa.Enabled = true;
                capnhat.Enabled = true;

                if (this.loai_tai_san == "Tài sản cố định")
                {
                    thoigianbaohanh.Enabled = true;
                    thoigiantrangbi.Enabled = true;
                    giatien.Enabled = true;
                    txt_giaitien_thue.Enabled = false;
              

                    thoigianbaohanh.Text = this.han_bao_hanh;
                    thoigiantrangbi.Text = this.ngay_trang_bi;
                    giatien.Text = this.gia_tien;

                }
                else
                {
                    thoigianbaohanh.Enabled = false;
                    thoigiantrangbi.Enabled = false;
                    giatien.Enabled = false;
                    txt_giaitien_thue.Enabled = true;
                    txt_giaitien_thue.Text = row.Cells[8].Value.ToString();
                  

                }
            }
            catch
            {

            }

        }
        private void tabledata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = tabledata.Rows[e.RowIndex];
                id = row.Cells[0].Value.ToString();
                this.ten_tai_san = row.Cells[1].Value.ToString();
                this.ten_cong_ty = row.Cells[2].Value.ToString();
                this.loai_tai_san = row.Cells[3].Value.ToString();
                this.han_bao_hanh = row.Cells[4].Value.ToString();
                this.ngay_trang_bi = row.Cells[5].Value.ToString();
                this.gia_tien = row.Cells[6].Value.ToString();
                this.gia_tien_thue = row.Cells[8].Value.ToString();
                tentaisan.Text = this.ten_tai_san;
                congty.Text = this.ten_cong_ty;
                cmLoaitaisan.Text = this.loai_tai_san;
                xoa.Enabled = true;
                capnhat.Enabled = true;

                if (this.loai_tai_san == "Tài sản cố định")
                {
                    thoigianbaohanh.Enabled = true;
                    thoigiantrangbi.Enabled = true;
                    giatien.Enabled = true;
                    txt_giaitien_thue.Enabled = false;

                    thoigianbaohanh.Text = this.han_bao_hanh;
                    thoigiantrangbi.Text = this.ngay_trang_bi;
                    giatien.Text = this.gia_tien;

                }
                else
                {
                    thoigianbaohanh.Enabled = false;
                    thoigiantrangbi.Enabled = false;
                    giatien.Enabled = false;
                    txt_giaitien_thue.Enabled = true;
                    txt_giaitien_thue.Text = row.Cells[8].Value.ToString();
               

                }
            }
            catch
            {

            }

        }

        private void timkiem_Click(object sender, EventArgs e)
        {
            if (txtTimkiem.Text != "")
            {


                string str = txtTimkiem.Text;
                string date_from = timkiem_date1.Text;
                string date_to = timkiem_date2.Text;
               string loai_tai_san = cmb_tim_kiem.SelectedItem.ToString();

                Connect connect = new Connect();
                DataTable dt = new DataTable();
                dt = connect.laybang("select * from tai_san where ten_tai_san like '%"+str+"%' and thoi_diem_trang_bi between '"+date_from+"' and '"+date_to+"' and loai_tai_san=N'"+loai_tai_san+"';");
                tabledata.DataSource = dt;

                
                
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài sản");
            }
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = new DialogResult();
            dg = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dangnhap_Click(object sender, EventArgs e)
        {
            if (txt_ten_nguoi_dung.Text == "")
            {
                errorProvider1.SetError(txt_ten_nguoi_dung,"vui lòng điền thông tin");
            }
            if (txt_mat_khau.Text == "")
            {
                errorProvider1.SetError(txt_mat_khau, "vui lòng điền thông tin");
            }
            if (txt_mat_khau.Text != "" && txt_ten_nguoi_dung.Text != "")
            {
                Connect connect = new Connect();
                string value = connect.xulydulieu2("select * from nguoi_dung where ten ='"+txt_ten_nguoi_dung.Text+"' and matkhau='"+txt_mat_khau.Text+"';");
                if (value !="")
                {
                    txt_mat_khau.Enabled = false;
                    txt_ten_nguoi_dung.Enabled = false;
                    dangnhap.Enabled = false;
                    them.Enabled = true;
                    tentaisan.Enabled = true;
                    congty.Enabled = true;
                    cmLoaitaisan.Enabled = true;
                    lichsu.Enabled = true;
                    btnDanhsanh.Enabled = true;
                    user_name = txt_ten_nguoi_dung.Text;
                    timkiem.Enabled = true;
                   
                    laydanhsachtaisan();
                   
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại tài khoản và mật khẩu của bạn!");
                }
            }

        }

        private void capnhat_Click(object sender, EventArgs e)
        {
            int value = 0;
            Connect connect = new Connect();
            if (tentaisan.Text == "")
            {
                errorProvider1.SetError(tentaisan, "Nhập tên tài sản");
            }
            if (congty.Text == "")
            {
                errorProvider1.SetError(congty, "Nhập tên công ty");
            }
            this.ls_nguoi_thay_doi = user_name;
            if (this.ten_tai_san != tentaisan.Text)
            {
                this.ls_ten = tentaisan.Text;
            }
            if (this.ten_cong_ty != congty.Text)
            {
                this.ls_congty = congty.Text;
            }
            if (this.gia_tien != giatien.Text)
            {
                this.ls_gia_tien = giatien.Text;
            }
            if (this.gia_tien_thue != txt_giaitien_thue.Text)
            {
                this.ls_gia_tien_thue = txt_giaitien_thue.Text;
            }
            if (this.loai_tai_san != cmLoaitaisan.SelectedItem.ToString())
            {
                this.ls_tai_san = cmLoaitaisan.SelectedItem.ToString();
            }
            if (this.han_bao_hanh != thoigianbaohanh.Text)
            {
                this.ls_thoi_gian_bao_hanh = thoigianbaohanh.Text;
            }
            if (this.ngay_trang_bi != thoigiantrangbi.Text)
            {
                this.ls_thoi_gian_trang_bi = thoigiantrangbi.Text;
            }
            this.ls_thoi_gian_thay_doi = DateTime.Now.ToString(" MM/dd/yyyy HH:mm:ss");
            MessageBox.Show(this.ls_thoi_gian_thay_doi);
         

            
            if (cmLoaitaisan.SelectedItem.ToString() == "Tài sản cố định")
            {


                value = connect.xulydulieu("UPDATE tai_san SET ten_tai_san = N'"+tentaisan.Text+"' ,cong_ty_so_huu = N'"+congty.Text+"',loai_tai_san = N'"+cmLoaitaisan.SelectedItem.ToString()+"',thoi_gian_bao_hanh = N'"+thoigianbaohanh.Text+"',thoi_diem_trang_bi = N'"+thoigiantrangbi.Text+"',gia_tien = "+giatien.Text+",ten_tai_khoan = N'"+user_name+"',gia_tien_thue=null WHERE id="+id+";");
                //value = connect.xulydulieu("update tai_san set ten_tai_san= N'dfgkhhjhjjhd',cong_ty_so_huu=N'dfgdf' , loai_tai_san = N'fdgdfg',thoi_gian_bao_hanh = N'01/01/1996',thoi_diem_trang_bi = N'01/01/1996' ,gia_tien=3432 where id =24;");
               // MessageBox.Show("UPDATE tai_san SET ten_tai_san = '" + tentaisan.Text + "' ,cong_ty_so_huu = '" + congty.Text + "',loai_tai_san = '" + cmLoaitaisan.SelectedItem.ToString() + "',thoi_gian_bao_hanh = '" + thoigianbaohanh.Text + "',thoi_diem_trang_bi = '" + thoigiantrangbi.Text + "',gia_tien = " + giatien.Text + ",ten_tai_khoan = '" + user_name + "'WHERE id=" + id + ";");
                Connect connect2 = new Connect();
                value = connect2.xulydulieu("insert into lich_su_thay_doi(ten,cong_ty,loai_tai_san,thoi_gian_bao_hanh,thoi_gian_trang_bi,gia_tien,nguoi_thay_doi,thoi_diem_thay_doi ) values(N'" + this.ls_ten + "',N'" + this.ls_congty + "',N'" + this.ls_tai_san + "','" + this.ls_thoi_gian_bao_hanh + "','" + this.ls_thoi_gian_trang_bi + "','" + this.ls_gia_tien + "','" + this.ls_nguoi_thay_doi + "','" + this.ls_thoi_gian_thay_doi + "');");
               // MessageBox.Show("insert into lich_su_thay_doi(ten,cong_ty,loai_tai_san,thoi_gian_bao_hanh,thoi_gian_trang_bi,gia_tien,nguoi_thay_doi,thoi_diem_thay_doi ) values(N'" + this.ls_ten + "',N'" + this.ls_congty + "',N'" + this.ls_tai_san + "','" + this.ls_thoi_gian_bao_hanh + "','" + this.ls_thoi_gian_trang_bi + "','" + this.ls_gia_tien + "','" + this.ls_nguoi_thay_doi + "','" + this.ls_thoi_gian_thay_doi + "');");
               //  value = connect.xulydulieu("insert into lich_su_thay_doi(ten,cong_ty,loai_tai_san,thoi_gian_bao_hanh,thoi_gian_trang_bi,gia_tien,nguoi_thay_doi,thoi_diem_thay_doi ) values(N'"+this.ls_ten+"',N'"+this.ls_congty+"',N'"+this.ls_tai_san+"','"+this.ls_thoi_gian_bao_hanh+"','"+this.ls_thoi_gian_trang_bi+"',"+this.ls_gia_tien+"','"+this.ls_nguoi_thay_doi+"','"+this.ls_thoi_gian_thay_doi+"');");

                //tentaisan.Text = "insert into lich_su_thay_doi(ten,cong_ty,loai_tai_san,thoi_gian_bao_hanh,thoi_gian_trang_bi,gia_tien,nguoi_thay_doi,thoi_diem_thay_doi ) values(N'" + this.ls_ten + "',N'" + this.ls_congty + "',N'" + this.ls_tai_san + "','" + this.ls_thoi_gian_bao_hanh + "','" + this.ls_thoi_gian_trang_bi + "','" + this.ls_gia_tien + "','" + this.ls_nguoi_thay_doi + "','" + this.ls_thoi_gian_thay_doi + "');";
            }
            else
            {
                value = connect.xulydulieu("update tai_san set ten_tai_san= N'" + tentaisan.Text + "',cong_ty_so_huu=N'" + congty.Text + "',gia_tien_thue ="+txt_giaitien_thue.Text+", thoi_gian_bao_hanh=null,thoi_diem_trang_bi=null,gia_tien=null where id="+id+";");
            //    MessageBox.Show("update tai_san set ten_tai_san= N'" + tentaisan.Text + "',cong_ty_so_huu=N'" + congty.Text + "',gia_tien_thue ='" + txt_giaitien_thue.Text + "' where id ="+id+";");
                Connect connect2 = new Connect();
                value = connect2.xulydulieu("insert into lich_su_thay_doi(ten,cong_ty,loai_tai_san,gia_tien_thue,nguoi_thay_doi,thoi_diem_thay_doi ) values(N'" + this.ls_ten + "',N'" + this.ls_congty + "',N'" + this.ls_tai_san + "','" + this.ls_gia_tien_thue + "','" + this.ls_nguoi_thay_doi + "','" + this.ls_thoi_gian_thay_doi + "');");
                   
            }

         //   MessageBox.Show(value.ToString());
             if (value > 0)
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                laydanhsachtaisan();
        }

        private void lichsu_Click(object sender, EventArgs e)
        {
            tentaisan.Text = "";
            congty.Text = "";
            giatien.Text = "";
            txt_giaitien_thue.Text = "";
            Connect connect = new Connect();
            DataTable dt = new DataTable();
            dt = connect.laybang("select * from lich_su_thay_doi;");
            tabledata.DataSource = dt;
            capnhat.Enabled = false;
            xoa.Enabled = false;

        }

        private void btnDanhsanh_Click(object sender, EventArgs e)
        {
            tentaisan.Text = "";
            congty.Text = "";
            giatien.Text = "";
            txt_giaitien_thue.Text = "";
            laydanhsachtaisan();
            capnhat.Enabled = true;
            xoa.Enabled = true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
