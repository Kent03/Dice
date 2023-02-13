using System;

namespace Dice_2
{
    internal class Program
    {
        //Bài con xúc sắc- Khôi 20mc-20it438
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            // Lặp 10 lần
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nhan 1 phim đe gieo xuc sac.");// Hiển thị thông báo yêu cầu người chơi nhấn phím bất kỳ

                Console.ReadKey(); // Đợi người chơi nhấn phím bất kỳ trước khi tạo số

                playerRandomNum = random.Next(1, 7); // Tạo một số ngẫu nhiên từ 1 đến 6 cho người chơi
                Console.WriteLine("Con xuc sac ban tung la " + playerRandomNum); // In ra số được tạo ngẫu nhiên của người chơi

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000); // Đợi một giây

                enemyRandomNum = random.Next(1, 7); // Tạo một số ngẫu nhiên từ 1 đến 6 cho đối thủ
                Console.WriteLine("Con xuc sac doi thu tung la " + enemyRandomNum); // In ra số được tạo ngẫu nhiên của đối thủ

                // Nếu người chơi cuộn cao hơn đối thủ
                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++; //Tăng điểm người chơi
                    Console.WriteLine("ban thang!"); // Hiển thị thông báo cho biết người chơi đã thắng 
                }
                else if (playerRandomNum < enemyRandomNum) // Nếu đối thủ  cao hơn người chơi
                {
                    enemyPoints++; // Increase enemy points
                    Console.WriteLine("Đoi thu thang!"); // Hiển thị thông báo cho biết kẻ thù đã thắng vòng này
                }
                else // Nếu người chơi và đối thủ đã tung ra cùng một số
                {
                    Console.WriteLine("Draw!"); // Hiển thị thông báo nói rằng vòng này là một trận hòa
                }

                // Hiển thị điểm
                Console.WriteLine("The score is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine(); 
            }

            // Nếu người chơi đã ghi điểm cao hơn 
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("Ban thang!"); // Hiển thị thông báo cho biết người chơi thắng
            }
            else if (playerPoints < enemyPoints) // Ngược lại
            {
                Console.WriteLine("ban thua!"); // Hiển thị thông báo cho biết người chơi thua
            }
            else // Nếu người chơi và đối thủ ghi được số điểm như nhau
            {
                Console.WriteLine("Hoa!"); // Hiển thị thông báo nói rằng đó là một trận hòa
            }

            Console.ReadKey(); // Đợi người dùng nhập trước khi đóng cửa sổ bảng điều khiển
        }
    }

    class Dice
    {
        private int die1;
        private int die2;

        public int Die1
        {
            get { return die1; }
            set { die1 = value; }
        }


        public int Die2
        {
            get { return die2; }
            set { die2 = value; }
        }

        public void Roll()
        {
            
            Random rand1 = new Random();
            Die1 = rand1.Next(1, 6);
            Die2 = rand1.Next(1, 6);
        }
    }
}
