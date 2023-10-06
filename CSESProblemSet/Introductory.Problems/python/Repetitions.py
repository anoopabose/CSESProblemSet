


# You are given a DNA sequence: a string consisting of characters A, C, G, and T. 
# Your task is to find the longest repetition in the sequence. 
# This is a maximum-length substring containing only one type of character.

class Repetitions:
    def Solve(str):
        max_count = 0
        count = 0
        prev = ''
        for i in range(len(str)):
            if prev == str[i]:
                count += 1
            else:
                count = 1
            prev = str[i]
            max_count = max(max_count, count)
        return max_count
    
    print(Solve(str(input())))

    
