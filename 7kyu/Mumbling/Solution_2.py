def accum(st):
    result = ""
    for i, c in enumerate(st):
        result += c.upper() + c.lower() * i + "-"
    
    return result[:-1]