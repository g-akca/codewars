def merge_arrays(first, second): 
    merged = list(set(first).union(set(second)))
    merged.sort()
    return merged