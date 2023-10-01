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

            loadSeet();
        }

        private void loadSeet()
        {
            for (char row = 'A'; row <= 'K'; row++)
            {
                if (row == 'I')
                {
                    continue;
                }
                int totalSeatsInRow = (row == 'K') ? 15 : 13;

                for (int seatNum = 1; seatNum <= totalSeatsInRow; seatNum++)
                {
                    string seatName = row + seatNum.ToString(); // Tạo tên ghế, ví dụ: "A1", "B2",...

                    Button seatButton = new Button();
                    seatButton.Name = seatName;
                    seatButton.Text = seatName;
                    seatButton.Width = 50; // Điều chỉnh kích thước của ghế tùy ý
                    seatButton.Height = 30;
                    seatButton.Click += SeatButton_Click; // Gắn sự kiện click cho ghế

                    tableLayoutPanelGhe.Controls.Add(seatButton); // Thêm ghế vào TableLayoutPanel
                }
            }
        }
        //thực hiện khi click vào ghế ở đây
        private void SeatButton_Click(object? sender, EventArgs e)
        {

        }

        /*
         * 1. checkout qua nhánh khác
         * 2. đổi màu các ghế + làm lại các label ở dưới
         * 3. thực hiện các thao tác khi click vào các ghế
        */
    }
}