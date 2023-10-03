using System.Reflection.Emit;

namespace ChuongTrinhDatVeXemPhim
{
    public partial class Form1 : Form
    {
        bool isSeat = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            loadSeatNormal();
            loadSeatVIP();
            loadSeatSweetBox();
        }

        private void loadSeatNormal()
        {
            for (char row = 'A'; row <= 'D'; row++)
            {
                int totalSeatsInRow = 13;

                // Đặt ColumnCount cho tableLayoutPanelGhe dựa trên tổng số ghế trong hàng này

                for (int seatNum = 1; seatNum <= totalSeatsInRow; seatNum++)
                {
                    string seatName = row + seatNum.ToString(); // Tạo tên ghế, ví dụ: "A1", "B2",...

                    Button seatButton = new Button();
                    seatButton.Name = seatName;
                    seatButton.Text = seatName;
                    seatButton.Width = 50; // Điều chỉnh kích thước của ghế tùy ý
                    seatButton.Height = 50;
                    seatButton.FlatStyle = FlatStyle.Flat;
                    seatButton.BackColor = Color.LightYellow;
                    seatButton.FlatAppearance.BorderColor = Color.Green;
                    seatButton.FlatAppearance.BorderSize = 2;
                    seatButton.Click += SeatButton_Click; // Gắn sự kiện click cho ghế
                    

                    tableLayoutPanelGheNormal.Controls.Add(seatButton); // Thêm ghế vào TableLayoutPanel
                    isSeat = false;
                }
            }
        }
        private void loadSeatVIP()
        {
            for (char row = 'E'; row <= 'J'; row++)
            {
                if (row == 'I')
                {
                    continue;
                }
                int totalSeatsInRow = 13;

                // Đặt ColumnCount cho tableLayoutPanelGhe dựa trên tổng số ghế trong hàng này

                for (int seatNum = 1; seatNum <= totalSeatsInRow; seatNum++)
                {
                    string seatName = row + seatNum.ToString(); // Tạo tên ghế, ví dụ: "A1", "B2",...

                    Button seatButton = new Button();
                    seatButton.Name = seatName;
                    seatButton.Text = seatName;
                    seatButton.Width = 50; // Điều chỉnh kích thước của ghế tùy ý
                    seatButton.Height = 50;
                    seatButton.FlatStyle = FlatStyle.Flat;
                    seatButton.BackColor = Color.LightYellow;
                    seatButton.FlatAppearance.BorderColor = Color.Red;
                    seatButton.FlatAppearance.BorderSize = 2;
                    seatButton.Click += SeatButton_Click; // Gắn sự kiện click cho ghế


                    tableLayoutPanelGheVIP.Controls.Add(seatButton); // Thêm ghế vào TableLayoutPanel
                    isSeat = false;
                }
            }
        }
        private void loadSeatSweetBox()
        {
            int totalSeatsInRow = 15;

            // Đặt ColumnCount cho tableLayoutPanelGhe dựa trên tổng số ghế trong hàng này

            for (int seatNum = 1; seatNum <= totalSeatsInRow; seatNum++)
            {
                string seatName = 'K' + seatNum.ToString(); // Tạo tên ghế, ví dụ: "A1", "B2",...

                Button seatButton = new Button();
                seatButton.Name = seatName;
                seatButton.Text = seatName;
                seatButton.Width = 50; // Điều chỉnh kích thước của ghế tùy ý
                seatButton.Height = 50;
                seatButton.BackColor = Color.LightPink;
                seatButton.FlatStyle = FlatStyle.Flat;
                seatButton.FlatAppearance.BorderSize = 0;
                seatButton.Click += SeatButton_Click; // Gắn sự kiện click cho ghế



                tableLayoutPanelGheSweetBox.Controls.Add(seatButton); // Thêm ghế vào TableLayoutPanel
                isSeat = true;
            }
        }
        //thực hiện khi click vào ghế ở đây

        private void SeatButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button seatButton) // Kiểm tra và chuyển đổi sender thành Button
            {
                if (!isSeat)
                {
                    
                    if (seatButton.BackColor == Color.LightPink) // Nếu là ghế SweetBox và ghế trống
                    {
                        seatButton.BackColor = Color.DarkRed; // Chọn ghế (đổi màu đỏ)
                    }
                    else if (seatButton.BackColor == Color.DarkRed) // Nếu ghế đã chọn
                    {
                        seatButton.BackColor = Color.LightPink; // Trở lại trạng thái ban đầu
                    }
                }
                else // Nếu đang chọn ghế SweetBox
                {
                    if (seatButton.BackColor == Color.LightYellow) // Nếu là ghế thường và ghế trống
                    {
                        seatButton.BackColor = Color.DarkRed; // Chọn ghế (đổi màu đỏ)
                    }
                    else if (seatButton.BackColor == Color.DarkRed) // Nếu ghế đã chọn
                    {
                        seatButton.BackColor = Color.LightYellow; // Trở lại trạng thái ban đầu
                    }
                }
            }
        }


    }
}