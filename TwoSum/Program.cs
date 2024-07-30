using TwoSum.Solution;

int[] array = { 2, 6, 10 };
int target = 8;

Solution solution = new Solution();

int[] solutionArray = solution.TwoSum(array, target);

for (int i = 0; i < solutionArray.Length; i++)
{
    Console.Write(solutionArray[i]);
    if (i!=solutionArray.Length-1)
    {
        Console.WriteLine(", ");
    }
}