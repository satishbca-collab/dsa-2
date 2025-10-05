public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        var current = new StringBuilder();
        Generate(0, 0, n, current, result);
        return result;
    }

    private void Generate(int open, int close, int max, StringBuilder current, List<string> result) {
        if (current.Length == max * 2) {
            result.Add(current.ToString());
            return;
        }

        if (open < max) {
            current.Append('(');                  // Add '(' if available
            Generate(open + 1, close, max, current, result);
            current.Length--;                     // Backtrack
        }

        if (close < open) {
            current.Append(')');                  // Add ')' only if it won’t invalidate
            Generate(open, close + 1, max, current, result);
            current.Length--;                     // Backtrack
        }
    }
}