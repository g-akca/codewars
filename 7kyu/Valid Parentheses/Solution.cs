public class Kata {
  public static bool ValidParentheses(string str) {
    int balance = 0;
    foreach (char c in str) {
        if (c == '(') balance++;
        else if (c == ')') {
            balance--;
            if (balance < 0) return false;
        }
    }

    return balance == 0;
  } 
}