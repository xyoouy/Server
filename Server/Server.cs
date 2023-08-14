namespace Server;

public static class Server
{
    private static int count;
    private static readonly ReaderWriterLockSlim rwLock = new();

    public static int GetCount()
    {
        rwLock.EnterReadLock();
        try
        {
            return count;
        }
        finally
        {
            rwLock.ExitReadLock();
        }
    }

    public static void AddToCount(int value)
    {
        rwLock.EnterWriteLock();
        try
        {
            count += value;
        }
        finally
        {
            rwLock.ExitWriteLock();
        }
    }
}



