VARIABLE rnd  HERE rnd ! 
: RANDOM  rnd @ 31421 *  6927 +  DUP rnd ! 
: CHOOSE  ( u1 -- u2 )  RANDOM UM*  NIP 
.( Welcome to Rock, Paper, Scissors, Forth style!) CR
.( Please select your move [R|P|S]:) 
KEY
DUP
CR
.( You chose: ) EMIT CR
3 CHOOSE
bye
