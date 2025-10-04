public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        var result = new List<IList<int>>();
        Helper(nums, result, new List<int>(), new bool[nums.Length]);
        return result;
    }

    private void Helper(int[] nums, IList<IList<int>> result, List<int> current, bool[] visited){
        if(current.Count == nums.Length){
            result.Add(new List<int>(current));
            return;
        }
        for(int i = 0; i < nums.Length; i++){
            if(visited[i] == false){
                visited[i] = true;
                current.Add(nums[i]);
                Helper(nums, result, current, visited);
                visited[i] = false;
                current.RemoveAt(current.Count - 1);
            }
        }
    }
}