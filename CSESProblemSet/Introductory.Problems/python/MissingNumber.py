class MissingNumber:
    def getMissingNumber(self, numbers, length):
        n = length
        return (n*(n+1)//2) - sum(numbers)   
       
    
    def Solve(self):
        n = int(input())
        numbers = list(map(int, input().split()))
        print(self.getMissingNumber(numbers,n))

if __name__ == '__main__':
    missingNumber = MissingNumber()
    missingNumber.Solve()
