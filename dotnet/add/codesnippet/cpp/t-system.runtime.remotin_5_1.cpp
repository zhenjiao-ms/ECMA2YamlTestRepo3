   ObjRef^ objRefSample = RemotingServices::GetObjRefForProxy( myRemoteObject );
   Console::WriteLine( "***ObjRef Details***" );
   Console::WriteLine( "URI:\t {0}", objRefSample->URI );
   array<Object^>^channelData = objRefSample->ChannelInfo->ChannelData;
   Console::WriteLine( "Channel Info:" );
   for each(Object^ o in channelData)
      Console::WriteLine("\t{0}", o->ToString());
   IEnvoyInfo^ envoyInfo = objRefSample->EnvoyInfo;
   if ( envoyInfo == nullptr )
   {
      Console::WriteLine( "This ObjRef does not have envoy information." );
   }
   else
   {
      IMessageSink^ envoySinks = envoyInfo->EnvoySinks;
      Console::WriteLine( "Envoy Sink Class: {0}", envoySinks );
   }
   IRemotingTypeInfo^ typeInfo = objRefSample->TypeInfo;
   Console::WriteLine( "Remote type name: {0}", typeInfo->TypeName );
   Console::WriteLine( "Can my Object cast to a Bitmap? {0}", typeInfo->CanCastTo( System::Drawing::Bitmap::typeid, objRefSample ) );
   Console::WriteLine( "Is this Object from this AppDomain? {0}", objRefSample->IsFromThisAppDomain() );
   Console::WriteLine( "Is this Object from this process? {0}", objRefSample->IsFromThisProcess() );