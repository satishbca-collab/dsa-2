public class Solution {
	public int Multiply(int a, int b) {
		if(a == 0 || b == 0) return 0;
		return a + Multiply(a, b-1);
	}
}

Solution s = new Solution();
Console.WriteLine(s.Multiply(3,2));
Console.WriteLine(s.Multiply(3,0));
Console.WriteLine(s.Multiply(0,3));
Console.WriteLine(s.Multiply(5,10));