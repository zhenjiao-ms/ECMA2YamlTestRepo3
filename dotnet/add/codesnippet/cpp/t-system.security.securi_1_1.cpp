using namespace System;
using namespace System::Security;
using namespace System::Collections;
ref class SecurityElementMembers
{
public:

   [STAThread]
   int TestSecurityElementMembers()
   {
      SecurityElement^ xmlRootElement = gcnew SecurityElement( L"RootTag",L"XML security tree" );

      AddAttribute( xmlRootElement, L"creationdate", DateTime::Now.ToString() );
      AddChildElement( xmlRootElement, L"destroytime", DateTime::Now.AddSeconds( 1.0 ).ToString() );
      
      SecurityElement^ windowsRoleElement = gcnew SecurityElement( L"WindowsMembership.WindowsRole" );

      windowsRoleElement->AddAttribute( L"version", L"1.00" );

      // Add a child element and a creationdate attribute.
      AddChildElement( windowsRoleElement, L"BabyElement", L"This is a child element" );
      AddAttribute( windowsRoleElement, L"creationdate", DateTime::Now.ToString() );
      
      xmlRootElement->AddChild( windowsRoleElement );

      CompareAttributes( xmlRootElement, L"creationdate" );
      ConvertToHashTable( xmlRootElement );
      DisplaySummary( xmlRootElement );

      // Determine if the security element is too old to keep.
      xmlRootElement = DestroyTree( xmlRootElement );
      if ( xmlRootElement != nullptr )
      {
         String^ elementInXml = xmlRootElement->ToString();

         Console::WriteLine( elementInXml );
      }

      Console::WriteLine( L"This sample completed successfully; "
      L"press Enter to exit." );
      Console::ReadLine();
      return 1;
   }


private:

   // Add an attribute to the specified security element.
   static SecurityElement^ AddAttribute( SecurityElement^ xmlElement, String^ attributeName, String^ attributeValue )
   {
      if ( xmlElement != nullptr )
      {
         // Verify that the attribute name and value are valid XML formats.
         if ( SecurityElement::IsValidAttributeName( attributeName ) &&
                SecurityElement::IsValidAttributeValue( attributeValue ) )
         {
            // Add the attribute to the security element.
            xmlElement->AddAttribute( attributeName, attributeValue );
         }
      }

      return xmlElement;
   }


   // Add a child element to the specified security element.
   static SecurityElement^ AddChildElement( SecurityElement^ parentElement, String^ tagName, String^ tagText )
   {
      if ( parentElement != nullptr )
      {
         // Ensure that the tag text is in valid XML format.
         if (  !SecurityElement::IsValidText( tagText ) )
         {
            // Replace invalid text with valid XML text 
            // to enforce proper XML formatting.
            tagText = SecurityElement::Escape( tagText );
         }

         // Determine whether the tag is in valid XML format.
         if ( SecurityElement::IsValidTag( tagName ) )
         {
            SecurityElement^ childElement;
            childElement = parentElement->SearchForChildByTag( tagName );
            if ( childElement != nullptr )
            {
               String^ elementText;
               elementText = parentElement->SearchForTextOfTag( tagName );
               if (  !elementText->Equals( tagText ) )
               {
                  // Add child element to the parent security element.
                  parentElement->AddChild( gcnew SecurityElement( tagName,tagText ) );
               }
            }
            else
            {
               // Add child element to the parent security element.
               parentElement->AddChild( gcnew SecurityElement( tagName,tagText ) );
            }
         }
      }

      return parentElement;
   }


   // Create and display a summary sentence 
   // about the specified security element.
   static void DisplaySummary( SecurityElement^ xmlElement )
   {
      // Retrieve tag name for the security element.
      String^ xmlTreeName = xmlElement->Tag->ToString();
      // Retrieve tag text for the security element.
      String^ xmlTreeDescription = xmlElement->Text;
      // Retrieve value of the creationdate attribute.
      String^ xmlCreationDate = xmlElement->Attribute(L"creationdate");
      // Retrieve the number of children under the security element.
      String^ childrenCount = xmlElement->Children->Count.ToString();
      String^ outputMessage = String::Format( L"The security XML tree named {0}", xmlTreeName );
      outputMessage = String::Concat( outputMessage, String::Format( L"({0})", xmlTreeDescription ) );
      outputMessage = String::Concat( outputMessage, String::Format( L" was created on {0} and ", xmlCreationDate ) );
      outputMessage = String::Concat( outputMessage, String::Format( L"contains {0} child elements.", childrenCount ) );
      Console::WriteLine( outputMessage );
   }

   // Compare the first two occurrences of an attribute 
   // in the specified security element.
   static void CompareAttributes( SecurityElement^ xmlElement, String^ attributeName )
   {
      // Create a hash table containing the security element's attributes.
      Hashtable^ attributeKeys = xmlElement->Attributes;
      String^ attributeValue = attributeKeys[ attributeName ]->ToString();
      IEnumerator^ myEnum = xmlElement->Children->GetEnumerator();
      while ( myEnum->MoveNext() )
      {
         SecurityElement^ xmlChild = safe_cast<SecurityElement^>(myEnum->Current);
         if ( attributeValue->Equals( xmlChild->Attribute(attributeName) ) )
         {
            // The security elements were created at the exact same time.
         }
      }
   }

   // Convert the contents of the specified security element 
   // to hash codes stored in a hash table.
   static void ConvertToHashTable( SecurityElement^ xmlElement )
   {
      // Create a hash table to hold hash codes of the security elements.
      Hashtable^ xmlAsHash = gcnew Hashtable;
      int rootIndex = xmlElement->GetHashCode();
      xmlAsHash->Add( rootIndex, L"root" );
      int parentNum = 0;
      IEnumerator^ myEnum1 = xmlElement->Children->GetEnumerator();
      while ( myEnum1->MoveNext() )
      {
         SecurityElement^ xmlParent = safe_cast<SecurityElement^>(myEnum1->Current);
         parentNum++;
         xmlAsHash->Add( xmlParent->GetHashCode(), String::Format( L"parent{0}", parentNum ) );
         if ( (xmlParent->Children != nullptr) && (xmlParent->Children->Count > 0) )
         {
            int childNum = 0;
            IEnumerator^ myEnum2 = xmlParent->Children->GetEnumerator();
            while ( myEnum2->MoveNext() )
            {
               SecurityElement^ xmlChild = safe_cast<SecurityElement^>(myEnum2->Current);
               childNum++;
               xmlAsHash->Add( xmlChild->GetHashCode(), String::Format( L"child{0}", childNum ) );
            }
         }
      }
   }

   // Delete the specified security element if the current time is past
   // the time stored in the destroytime tag.
   static SecurityElement^ DestroyTree( SecurityElement^ xmlElement )
   {
      SecurityElement^ localXmlElement = xmlElement;
      SecurityElement^ destroyElement = localXmlElement->SearchForChildByTag( L"destroytime" );
      
      // Verify that a destroytime tag exists.
      if ( localXmlElement->SearchForChildByTag( L"destroytime" ) != nullptr )
      {
         // Retrieve the destroytime text to get the time 
         // the tree can be destroyed.
         String^ storedDestroyTime = localXmlElement->SearchForTextOfTag( L"destroytime" );
         DateTime destroyTime = DateTime::Parse( storedDestroyTime );
         if ( DateTime::Now > destroyTime )
         {
            localXmlElement = nullptr;
            Console::WriteLine( L"The XML security tree has been deleted." );
         }
      }

      
      // Verify that xmlElement is of type SecurityElement.
      if ( xmlElement->GetType()->Equals( System::Security::SecurityElement::typeid ) )
      {
         // Determine whether the localXmlElement object 
         // differs from xmlElement.
         if ( xmlElement->Equals( localXmlElement ) )
         {
            // Verify that the tags, attributes and children of the
            // two security elements are identical.
            if ( xmlElement->Equal( localXmlElement ) )
            {
               // Return the original security element.
               return xmlElement;
            }
         }
      }

      // Return the modified security element.
      return localXmlElement;
   }

};

int main()
{
   SecurityElementMembers^ sem = gcnew SecurityElementMembers;
   sem->TestSecurityElementMembers();
}

//
// This sample produces the following output:
// 
// The security XML tree named RootTag(XML security tree) 
// was created on 2/23/2004 1:23:00 PM and contains 2 child elements.
//<RootTag creationdate="2/23/2004 1:23:00 PM">XML security tree
//   <destroytime>2/23/2004 1:23:01 PM</destroytime>
//   <WindowsMembership.WindowsRole version="1.00"
//                                  creationdate="2/23/2004 1:23:00 PM">
//      <BabyElement>This is a child element.</BabyElement>
//   </WindowsMembership.WindowsRole>
//</RootTag>
//
//This sample completed successfully; press Exit to continue.