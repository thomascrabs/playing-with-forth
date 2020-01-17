.( Welcome to Rock, Paper, Scissors, Forth style!) CR
.( Please select your move [R|P|S]:) 
KEY
DUP
CR
.( You chose: ) EMIT CR
VARIABLE rnd   HERE rnd ! 
: RANDOM  rnd @ 3141592621  *  6927 +  DUP rnd ! ;
: CHOOSE  ( u1 -- u2 )  RANDOM UM*  NIP ; 

3 CHOOSE 

: ?CHECKCOMPUTER
  DUP 0 = IF DROP 82 ELSE 
  DUP 1 = IF DROP 80 ELSE 
  DUP 2 = IF DROP 83 ELSE 
  THEN THEN THEN ;
?CHECKCOMPUTER
DUP
.( Computer picked: ) EMIT CR
: ?CHECKMATCH
  = IF ." That's a draw, try again " CR THEN ; 
?CHECKMATCH
.s CR
bye
