def count_positives_sum_negatives(arr):
    if arr is None or len(arr) == 0:
        return []
    pos_count = len([num for num in arr if num > 0])
    neg_sum = sum([num for num in arr if num < 0])
    return [pos_count, neg_sum]