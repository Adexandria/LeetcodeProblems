// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] numms = { 3,2,3 };
int target = 6;
int[] result = TwoSum(numms, target);
int steps = ClimbStairs(2);  
foreach (var item in result)
{
    Console.WriteLine(item);
}
Console.WriteLine(steps);
Array.Sort(numms);
Console.WriteLine(RemoveDuplicates(numms));

int[] TwoSum(int[] nums, int target)
{
    
    int left = 0;
    int right = nums.Length;
    while (left < right - 1)
    {
        int[] result = FindSum(left + 1, left,target, nums);
        if(result.Length == 2)
        {
            return result;
        }
        left++;
    }
    return Array.Empty<int>();
}

int[] FindSum(int left,int value,int target, int[] nums)
{
    if(left == nums.Length)
    {
        return Array.Empty<int>();
    }
    if (nums[left] + nums[value] == target)
    {
        return new int[] { value,left };
    }
    return FindSum(left + 1,value,target, nums);
}

int ClimbStairs(int n)
{
    if (n == 1)
    {
        return 1;
    }
    int first = 1;
    int second = 2;
    for (int i = 3; i <= n; i++)
    {
        int third = first + second;
        first = second;
        second = third;
    }
    return second;
}

int RemoveDuplicates(int[] nums) {
    int count = 0;
    int left = 1;
    int right = nums.Length;
    while (left < right)
    {
        if (nums[left] == nums[left - 1])
        {
            count++;
        }
        else
        {
            nums[left - count] = nums[left];
        }
        left++;
    }
    return nums.Length - count;
}