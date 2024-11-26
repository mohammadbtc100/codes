include 'emu8086.inc'
org 100h
print 'Enter number : '
call scan_num  ;cx=2
mov ax,100 ;ax=100
mul cx     ;eax=ax*cx  eax=100*2
gotoxy 0,3          
print 'result : '
gotoxy 10,3          
call print_num   ;print(eax) 
ret
DEFINE_SCAN_NUM
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS
end


