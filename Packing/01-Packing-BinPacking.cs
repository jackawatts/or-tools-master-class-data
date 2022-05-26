using System;
using Google.OrTools.LinearSolver;

public class BinPackingMip
{
    class DataModel
    {
        public static double[] Weights = { 48, 30, 19, 36, 36, 27, 42, 42, 36, 24, 30 };
        public int NumItems = Weights.Length;
        public int NumBins = Weights.Length;
        public double BinCapacity = 95.0;
    }

    public static void Main()
    {
        var data = new DataModel();
        // TODO:






        // SOLVE
        var resultStatus = solver.Solve();

        // Check that the problem has an optimal solution.
        if (resultStatus != Solver.ResultStatus.OPTIMAL)
        {
            Console.WriteLine("The problem does not have an optimal solution!");
            return;
        }
        Console.WriteLine($"Number of bins used: {solver.Objective().Value()}");
        double TotalWeight = 0.0;
        for (int j = 0; j < data.NumBins; ++j)
        {
            double BinWeight = 0.0;
            if (binIsUsed[j].SolutionValue() == 1)
            {
                Console.WriteLine($"Bin {j}");
                for (int i = 0; i < data.NumItems; ++i)
                {
                    if (itemBins[i, j].SolutionValue() == 1)
                    {
                        Console.WriteLine($"Item {i} weight: {DataModel.Weights[i]}");
                        BinWeight += DataModel.Weights[i];
                    }
                }
                Console.WriteLine($"Packed bin weight: {BinWeight}");
                TotalWeight += BinWeight;
            }
        }
        Console.WriteLine($"Total packed weight: {TotalWeight}");
    }
}
