public class Solution {
	public int ModExp(int a, int b, int c){
		// code here
        if(b == 0) return 1 % c;
		if(b == 1) return ((a % c) + c) % c;
		long res;
		if(b % 2 == 0){
			res = powMod(a, b/2, c);
			res = (res*res) % c;
		}
		else {
			res = a % c;
			// why mod operation is done twice?
			res = (res * (powMod(a, b - 1, c)%c)) % c;
		}
		// why mod operation here?
		return (int)(res + c) % c;
	}
}

Solution s = new Solution();
Console.WriteLine(s.ModExp(2,10,5));
Console.WriteLine(s.ModExp(-3,5,10));