internal class Program
{
    private static void Main(string[] args)
    {
        int screenWidth = 80;
        int screenHeight = 20;
        int ballX = 0;
        int ballY = 0;
        int directionX = 1;
        int directionY = 1;

        while (true)
        {
            Console.Clear();

            ballX += directionX;
            ballY += directionY;

            if (ballX >= screenWidth)
            {
                ballX = screenWidth - 1;
                directionX = 0;
                directionY = 1;
            }
            else if (ballX < 0)
            {
                ballX = 0;
                directionX = 0;
                directionY = -1;
            }

            if (ballY >= screenHeight)
            {
                ballY = screenHeight - 1;
                directionX = -1;
                directionY = 0;
            }
            else if (ballY < 0)
            {
                ballY = 0;
                directionX = 1;
                directionY = 0;
            }

            DrawBall(ballX, ballY);

            Thread.Sleep(100); // Задержка для плавности движени
        }

        static void DrawBall(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("O");
        }
    }
}