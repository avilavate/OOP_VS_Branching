## Replacing null checks and Null values with Null objects

### Problem Statement:

  Note this implementation doesnt support following scenarios:
           	1- We cannot create an article with no moneyback guarantee.
		2- We cannot create an article with no repair guarantee.
		3- Passing null to SoldItem constructor will also not solve above problems because:
                   a- Passing null will throw ArgumentNullException from SoldItem ctor
                   b- if we disable validation in SoldItem ctor than the client code (i.e. Main() method will have to test
                      for null before it makes a call to ISValid on SoldItem class
                      
###  Solution:
		 1- Implement null objects (VoidGuarentee).
		 2- Singleton pattern (To avoid recreating null object VoidGuarentee again & again)
                     
 
