    // Create an empty PublisherIdentityPermission to serve as the target of the copy.
    publisherPerm2 = gcnew PublisherIdentityPermission(PermissionState::None);
    publisherPerm2 = (PublisherIdentityPermission^)publisherPerm1->Copy();
    Console::WriteLine("Result of copy = " + publisherPerm2);