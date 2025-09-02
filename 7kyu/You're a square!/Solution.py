import math

def is_square(n):    
    if n < 0 or math.sqrt(n) != int(math.sqrt(n)):
        return False
    return True