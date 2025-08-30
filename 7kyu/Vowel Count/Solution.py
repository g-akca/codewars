def get_count(sentence):
    vowels = ['a', 'e', 'u', 'i', 'o']
    vowel_count = 0
    for c in sentence:
        if c in vowels:
            vowel_count += 1
            
    return vowel_count