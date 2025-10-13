public class Solution {
    public int[] SortArray(int[] nums) {
        return counting(nums);
    }

    private int[] counting(int[] nums){
        int n = nums.Length, min= Int32.MaxValue, max=Int32.MinValue;

        for(int i = 0; i < n; i++){
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
        }

        int range = max-min+1;
        int[] table = new int[range];

        for(int i = 0; i < n; i++){
            int key = nums[i]-min;
            table[key]++;
        }

        for(int i = 1; i < range; i++){
            table[i] += table[i-1];
        }

        int[] result = new int[n];
        for(int i = n-1; i >= 0; i--){
            int key = nums[i] - min;
            table[key]--;
            int index = table[key];
            result[index] = nums[i];
        }

        return result;
    }

    private int[] insertion(int[] nums){
        int n = nums.Length;

        for(int i = 1; i < n; i++){
            int j = i-1, key = nums[i];
            while(j >= 0 && key < nums[j]){
                nums[j+1] = nums[j];
                j--;
            }
            nums[j+1] = key;
        }
        return nums;
    }

    private int[] selection(int[] nums){
        int n = nums.Length;
        for(int i = 0; i < n-1; i++){
            int min = i;
            for(int j = i+1; j < n; j++){
                if(nums[min] > nums[j]){
                    min = j;
                }
            }
            swap(nums, min, i);
        }
        return nums;
    }

    private int[] bubble(int[] nums){
        int n = nums.Length;
        for(int i = 0; i < n; i++){
            for(int j = 0; j < n-i-1; j++){
                if(nums[j] > nums[j+1]){
                    swap(nums, j, j+1);
                }
            }
        }
        return nums;
    }

    private void swap(int[] nums, int i, int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}