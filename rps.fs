.( Welcome to Rock, Paper, Scissors, Forth style!) CR
.( Please select your move [R|P|S]:) 
KEY
DUP
CR
.( You chose: ) EMIT CR
.s CR
VARIABLE rnd   HERE rnd !
: RANDOM  rnd @ 31421 *  6927 +  DUP rnd ! ;
: CHOOSE  ( u1 -- u2 )  RANDOM UM*  NIP ;
\ something that produces something more random????? : REALCHOICE  ( n -- ) 0 DO 3 CHOOSE . LOOP ; 
3 CHOOSE 
DUP
.s  CR
.( Computer picked: ) EMIT CR
\ : CHECKIFSAME ( -- ) = if ." Same value"
CR
bye
