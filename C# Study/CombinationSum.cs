// Leetcode #39: Combination Sum
// Time Complexity: O(n^2) Space Complexity: O(n)
public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Search(candidates, target, 0, 0, new List<int>(), result);
        return result;
    }

    private void Search(int[] candidates, int target, int index, int sum, IList<int> temp, IList<IList<int>> result)
    {
        if (sum == target)
        {
            result.Add(temp.ToArray());
            return;
        }

        while (sum < target && index < candidates.Length)
        {
            temp.Add(candidates[index]);
            Search(candidates, target, index, sum + candidates[index], temp, result);
            temp.RemoveAt(temp.Count - 1);
            index++;
        }
    }
}

// Try 1
public class Solution1 {
    public IList<IList<int>> CombinationSum(int[] candidates, int target){
        var result = new List<IList<int>>();
        Search(candidates, target, 0, 0, new List<int>(), result);
        return result;
    }
    private void Search(int[] candidates, int target, int index, int IList<int> temp, IList<IList<int>> result)
    {
        if(sum == target)
        {
            result.Add(temp.ToArray());
            return;
        }
        while(sum < target && index << candidates.Length)
        {
            temp.Add(candidates[index]);
            Search(candidates, target, index, sum + candidates[index], temp, result);
            temp.RemoveAt(temp.Count - 1);
            index++;
        }
    }
}

// Try 2
public class Solution2{
    public IList<IList<int>> CombinationSum(int[] candidates, int target){
        var result = new List<IList<int>>();
        Search(candidates, target, 0, 0, new List<int>(), result);
        return result;
    }
    private void Search(int[] candidates, int target, int index, int IList<int> temp, IList<IList<int>> result)
    {
        if(sum == target)
        {
            result.Add(temp.ToArray());
            return;
        }
        while(sum < target && index << candidates.Length)
        {
            temp.Add(candidates[index]);
            Search(candidates, target, index, sum + candidates[index], temp, result);
            temp.RemoveAt(temp.Count - 1);
            index++;
        }
    }
}

// Try 3
public class Solution3{
    public IList<IList<int>> CombinationSum(int[] candidates, int target){
        var result = new List<IList<int>>();
        Search(candidates, target, 0, 0, new List<int>(), result);
        return result;
    }
    private void Search(int[] candidates, int target, int index, int IList<int> temp, IList<IList<int>> result)
    {
        if (sum == target)
        {
            result.Add(temp.ToArray());
            return;
        }
        while(sum < target && index << candidates.Length)
        {
            temp.Add(candidates[index]);
            Search(candidates, target, index, sum + candidates[index], temp, result);
            temp.RemoveAt(temp.Count - 1);
            index++;
        }
    }
}