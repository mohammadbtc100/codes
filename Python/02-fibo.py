#Fibonacci Numbers
class Calculation:
    def fibonacci(self,n):
        if n is not int:
            return "The input is not correct!"
        a=0
        b=1
        c=1
        if n==1:
            return a
        if n in [2,3]:
            return b
        else:
            i=4; a=1
            while i<=n:
                c=a+b
                a=b
                b=c
                i+=1
            return c
        
#main function
def main():
    calc=Calculation()
    x=calc.fibonacci(11)
    print(x,' = ',x)
        

if __name__=="__main__":
    main()
    
