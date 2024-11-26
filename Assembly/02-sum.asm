include 'emu8086.inc'
org 100h
print 'Enter a number : '
call scan_num   ;cx=5
mov ax,cx       ;ax=5
gotoxy 0,1 
print 'Enter a number : '
call scan_num   ;cx=2
add ax,cx       ;eax=ax+cx=5+2=7
gotoxy 0,2
print 'sum is '
gotoxy 8,2
call print_num       ;print(eax)
ret
DEFINE_SCAN_NUM
DEFINE_PRINT_NUM
DEFINE_PRINT_NUM_UNS
end


