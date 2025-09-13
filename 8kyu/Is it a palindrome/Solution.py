def is_palindrome(s):
    for i in range(0, len(s) // 2):
        if s[i].lower() != s[-1 - i].lower():
            return False
    return True
