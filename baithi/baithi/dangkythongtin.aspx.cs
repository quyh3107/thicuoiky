using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace baithi
{
    public partial class dangkythongtin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDangKy_Click(Object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblThongBao.Text = string.Format($"Bạn {txtHoTen.Text} đăng ký thành công! <br/> Tên đăng nhập: {txtTenDangNhap.Text} <br/> Mật khẩu: {txtMatKhau.Text} <br/> Năm sinh: {txtNamSinh.Text} <br/> Số điện thoại: {txtDienThoai.Text} <br/> Email: {txtEmail.Text} <br/> Địa chỉ: {txtDiaChi.Text} <br/> Sở thích: {txtSoThich.Text}");
            }
        }
    }
}