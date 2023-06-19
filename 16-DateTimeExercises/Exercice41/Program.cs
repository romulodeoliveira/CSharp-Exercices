/*
Write a C# Sharp program to convert the specified string representation of a date and time to its DateTime equivalent.

Expected Output :

Attempting to parse strings using en-US culture.                                 
  Converted '05/01/2016 14:57:32.8' to 5/1/2016 2:57:32 PM (Unspecified).        
  Converted '2016-05-01 14:57:32.8' to 5/1/2016 2:57:32 PM (Unspecified).        
  Converted '2016-05-01T14:57:32.8375298-04:00' to 5/2/2016 12:27:32 AM (Local). 
  Converted '5/01/2015' to 5/1/2015 12:00:00 AM (Unspecified).                   
  Converted '5/01/2015 14:57:32.80 -07:00' to 5/2/2015 3:27:32 AM (Local).       
  Converted '1 May 2015 2:57:32.8 PM' to 5/1/2015 2:57:32 PM (Unspecified).      
  Unable to parse '16-05-2016 1:00:32 PM'.                                       
  Unable to parse 'Fri, 15 May 2016 20:10:57 GMT'.   
*/