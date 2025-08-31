def accum(st):
    result = ""
    n = 0
    for c in st:
        result += c.upper()
        for i in range(n):
            result += c.lower()
        n += 1
        result += "-"
    
    return result[:-1]