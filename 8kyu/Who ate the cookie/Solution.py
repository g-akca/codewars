def cookie(x):
    if isinstance(x, str):
        return "Who ate the last cookie? It was Zach!"
    elif isinstance(x, bool):
        return "Who ate the last cookie? It was the dog!"
    elif isinstance(x, (int, float)):
        return "Who ate the last cookie? It was Monica!"
    return "Who ate the last cookie? It was the dog!"