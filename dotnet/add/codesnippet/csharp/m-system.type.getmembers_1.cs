class MyClass
{
   public int myInt = 0;
   public string myString = null;

   public MyClass()
   {
   }
   public void Myfunction()
   {
   }
}

class Type_GetMembers
{
   public static void Main()
   {
      try
      {
         MyClass myObject = new MyClass();
         MemberInfo[] myMemberInfo; 

         // Get the type of 'MyClass'.
         Type myType = myObject.GetType(); 
        
         // Get the information related to all public member's of 'MyClass'. 
         myMemberInfo = myType.GetMembers();
    
         Console.WriteLine( "\nThe members of class '{0}' are :\n", myType); 
         for (int i =0 ; i < myMemberInfo.Length ; i++)
         {
            // Display name and type of the concerned member.
            Console.WriteLine( "'{0}' is a {1}", myMemberInfo[i].Name, myMemberInfo[i].MemberType);
         }
      }
      catch(SecurityException e)
      {
         Console.WriteLine("Exception : " + e.Message ); 
      }
   }
}