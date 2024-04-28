namespace AlgoCSharp.Algorithms
{
    using System;

    class ResourceHolder
    {
        // Assume this class holds some unmanaged resource
        private IntPtr unmanagedResource;
        private bool isDisposed = false;

        public ResourceHolder()
        {
            // Simulate allocation of an unmanaged resource
            unmanagedResource = System.Runtime.InteropServices.Marshal.AllocHGlobal(100);
            Console.WriteLine("Unmanaged resource allocated.");
        }

        // Destructor
        ~ResourceHolder()
        {
            Dispose(false);
            Console.WriteLine("Destructor called.");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!isDisposed)
            {
                if (disposing)
                {
                    // Dispose managed resources
                    // e.g., managed objects that implement IDisposable
                }

                // Free unmanaged resources
                if (unmanagedResource != IntPtr.Zero)
                {
                    System.Runtime.InteropServices.Marshal.FreeHGlobal(unmanagedResource);
                    unmanagedResource = IntPtr.Zero;
                    Console.WriteLine("Unmanaged resource freed.");
                }

                isDisposed = true;
            }
        }
    }
}
