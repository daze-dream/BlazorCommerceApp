# CommerceASPIdentity
How it works:
-	Added database connection to program
-	Did initial migrations so ASP.NET put its default tables in
-	Modified database to use the default UserID string provided in default tables
-	Create accounts and log in with the default provision
-	In the program, capture the ID through some authentication
-	Use it to match against the new FK/PK in database
-	Viola...sort of! Authentication works and only transactions of that userID are shown

# How to Use
Just click on the Transactions page on the side.
