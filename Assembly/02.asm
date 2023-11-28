include 'emu8086.inc'
org 100h
   

printn 'Hello Assembly'
gotoxy 0,1    
printn 'Computer Software Engineering'

print 'Enter number : '
call scan_num


mov al,100
mul cx

gotoxy 0,3          
print 'result : '
gotoxy 10,3          
call print_num
   
ret

DEFINE_SCAN_NUM
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS

end



