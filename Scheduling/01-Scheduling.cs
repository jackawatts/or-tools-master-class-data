    public class WallArt
    {
        public static void Main(string[] args)
        {
            const int numDays = 7;
            const int numShifts = 3; // morning, afternoon, night
            var employeeNames = new[] {
                "Katherine Ince",
                "Sophie Paterson",
                "Julian Quinn",
                "Charles Quinn",
                "Wendy Davidson",
                "Jan McGrath",
                "Colin Kerr",
                "Amelia Walker",
                "Donna Kelly",
                "Andrea Turner",
                "Justin Dyer",
                "Amelia Randall",
                "Steven Springer",
                "Carol Hudson",
                "Christian Glover",
                "Wanda Fisher",
                "Joanne Lyman",
                "David Wallace",
                "Victor Hunter",
                "Jake Mackenzie",
                "Julian Berry",
                "Colin Knox",
                "Fiona Langdon",
                "Ella Vaughan",
                "Isaac Paterson",
                "Owen Mackay",
                "Wanda Henderson",
                "Alison Newman",
                "Joshua Reid",
                "Una Marshall"
            };

            var numEmployees = employeeNames.Length;
            int[] allEmployees = Enumerable.Range(0, numEmployees).ToArray();
            int[] allDays = Enumerable.Range(0, numDays).ToArray();
            int[] allShifts = Enumerable.Range(0, numShifts).ToArray();
            int shiftSize = 8;
            int[,,] shiftRequests = new int[,,] {
                {
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                            {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                            {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                },
                {
                    { 0, 1, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 1 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 0, 0 },
                },
                {
                    { 0, 0, 0 },
                    { 0, 0, 1 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                    { 1, 0, 0 },
                    { 0, 1, 0 },
                    { 0, 0, 0 },
                }
            };

            // TODO















            // SOLVE
            var solver = new CpSolver();
            CpSolverStatus status = solver.Solve(model);
            Console.WriteLine($"Solve status: {status}");

            if (status == CpSolverStatus.Optimal || status == CpSolverStatus.Feasible)
            {
                Console.WriteLine("Solution:");
                foreach (var d in allDays)
                {
                    Console.WriteLine((DayOfWeek)(d));
                    foreach (var e in allEmployees)
                    {
                        bool isWorking = false;
                        foreach (int s in allShifts)
                        {
                            var key = Tuple.Create(e, d, s);
                            if (solver.Value(shifts[key]) == 1L)
                            {
                                if (shiftRequests[e, d, s] == 1)
                                {
                                    Console.WriteLine($"  {employeeNames[e]} works shift {s} (requested).");
                                }
                                else
                                {
                                    Console.WriteLine($"  {employeeNames[e]} works shift {s} (not requested).");
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(
                    $"Number of shift requests met = {solver.ObjectiveValue} (out of {numEmployees * minShiftsPeremployee}).");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }

            Console.WriteLine("Statistics");
            Console.WriteLine($"  conflicts: {solver.NumConflicts()}");
            Console.WriteLine($"  branches : {solver.NumBranches()}");
            Console.WriteLine($"  wall time: {solver.WallTime()}s");
        }
    }