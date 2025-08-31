def find_even_index(arr):
    total_sum = sum(arr)
    current_sum = 0
    for i in range(0, len(arr)):
        if i != 0:
            current_sum += arr[i - 1]
        if current_sum == (total_sum - arr[i]) / 2:
            return i
    return -1