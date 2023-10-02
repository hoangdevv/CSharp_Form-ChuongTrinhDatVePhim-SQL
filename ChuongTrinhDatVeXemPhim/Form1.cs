using System.Reflection.Emit;

namespace ChuongTrinhDatVeXemPhim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            loadSeetNormal();
            loadSeetVIP();
            loadSeetSweetBox();
        }

        private void loadSeetNormal()
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
                    seatButton.FlatAppearance.BorderColor = Color.Green;
                    seatButton.FlatAppearance.BorderSize = 2;
                    seatButton.Click += SeatButton_Click; // Gắn sự kiện click cho ghế
                    

                    tableLayoutPanelGheNormal.Controls.Add(seatButton); // Thêm ghế vào TableLayoutPanel
                }
            }
        }
        private void loadSeetVIP()
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
                    seatButton.FlatAppearance.BorderColor = Color.Red;
                    seatButton.FlatAppearance.BorderSize = 2;
                    seatButton.Click += SeatButton_Click; // Gắn sự kiện click cho ghế

                    tableLayoutPanelGheVIP.Controls.Add(seatButton); // Thêm ghế vào TableLayoutPanel
                }
            }
        }
        private void loadSeetSweetBox()
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
            }
        }
        //thực hiện khi click vào ghế ở đây
        private void SeatButton_Click(object? sender, EventArgs e)
        {
            Button seatButton = sender as Button;
            if (seatButton != null)
            {
                seatButton.FlatStyle = FlatStyle.Flat;
                seatButton.FlatAppearance.BorderSize = 0;
                seatButton.Text = "";
                seatButton.BackColor = Color.DarkRed;
            }
        }

        /*
         * 1. checkout qua nhánh khác
         * 2. đổi màu các ghế + làm lại các label ở dưới
         * 3. thực hiện các thao tác khi click vào các ghế
        */
    }
}