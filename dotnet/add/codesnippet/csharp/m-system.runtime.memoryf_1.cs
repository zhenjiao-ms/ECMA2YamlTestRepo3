    private static int EstimateMemoryUsageInMB()
    {
        int memUsageInMB = 0;

        long memBefore = GC.GetTotalMemory(true);
        int numGen0Collections = GC.CollectionCount(0);
        // Execute a test version of the method to estimate memory requirements.
        // This test method only exists to determine the memory requirements.
        ThreadMethod();
        // Includes garbage generated by the worker function.
        long memAfter = GC.GetTotalMemory(false);
        // If a garbage collection occurs during the measuring, you might need a greater memory requirement.
        Console.WriteLine("Did a GC occur while measuring?  {0}", numGen0Collections == GC.CollectionCount(0));
        // Set the field used as the parameter for the MemoryFailPoint constructor.
        long memUsage = (memAfter - memBefore);
        if (memUsage < 0)
        {
            Console.WriteLine("GC's occurred while measuring memory usage.  Try measuring again.");
            memUsage = 1 << 20;
        }

        // Round up to the nearest MB.
        memUsageInMB = (int)(1 + (memUsage >> 20));
        Console.WriteLine("Memory usage estimate: {0} bytes, rounded to {1} MB", memUsage, memUsageInMB);
        return memUsageInMB;
    }