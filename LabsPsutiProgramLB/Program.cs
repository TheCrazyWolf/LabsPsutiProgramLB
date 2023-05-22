using ScottPlot;

internal class Program
{
    private static void Main(string[] args)
    {
        double h = 0.05;
        double x = -10;
        double endX = 10;

        double[] xData = new double[(int)((endX - x) / h) + 1];
        double[] yData = new double[xData.Length];

        for (int i = 0; i < xData.Length; i++)
        {
            double y = 1.0 / (x + 1) + 2;
            xData[i] = x;
            yData[i] = y;
            x += h;
        }

        // Создание графического окна
        var plt = new Plot(600, 400);
        plt.PlotScatter(xData, yData);
        plt.Title("График функции y(x)");
        plt.XLabel("x");
        plt.YLabel("y");

        // Отображение графика
        plt.SaveFig("graph.png"); // Сохранение графика в файл
        plt.Render(); // Отображение графика в окне

        Console.ReadKey();
    }
}