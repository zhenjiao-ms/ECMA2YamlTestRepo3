   // Creates an instance of a context-bound type SampleSynchronized.
   SampleSynchronized^ sampSyncObj = gcnew SampleSynchronized;
   
   // Checks whether the Object* is a proxy, since it is context-bound.
   if ( RemotingServices::IsTransparentProxy( sampSyncObj ) )
      Console::WriteLine( "sampSyncObj is a proxy." );
   else
      Console::WriteLine( "sampSyncObj is NOT a proxy." );

   