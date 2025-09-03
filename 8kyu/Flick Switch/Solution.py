def flick_switch(lst):
    current = True
    result = []
    for item in lst:
        if item == "flick":
            current = not current
        result.append(current)
    return result
