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
  2DUP = IF ." That's a draw, try again :|" CR ELSE
  2DUP 82 = SWAP 80 = SWAP AND IF ." Rock beats paper, you lose :(" ELSE
  2DUP 82 = SWAP 83 = SWAP AND IF ." Rock smashes scissors, you lose :(" ELSE 
  2DUP 80 = SWAP 83 = SWAP AND IF ." Scissors cuts paper, you win :)" ELSE 
  2DUP 80 = SWAP 82 = SWAP AND IF ." Rock beats paper, you win :)" ELSE
  2DUP 83 = SWAP 80 = SWAP AND IF ." Scissors cuts paper, you lose :(" ELSE
  2DUP 83 = SWAP 82 = SWAP AND IF ." Rock smashes scissors, you win :)" ELSE
  THEN THEN THEN THEN THEN THEN THEN ; 
?CHECKMATCH
CR
bye
