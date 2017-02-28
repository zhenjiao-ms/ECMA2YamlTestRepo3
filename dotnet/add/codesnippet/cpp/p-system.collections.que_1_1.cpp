        Queue^ myCollection = gcnew Queue();
        bool lockTaken = false;
        try
        {
            Monitor::Enter(myCollection->SyncRoot, lockTaken);
            for each (Object^ item in myCollection);
            {
                // Insert your code here.
            }
        }
        finally
        {
            if (lockTaken)
            {
                Monitor::Exit(myCollection->SyncRoot);
            }
        }