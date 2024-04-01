using System.Runtime.InteropServices;
namespace mis3013
{
    public static class GetAddress
    {
        //public static IntPtr Get(Object o)
        //{
        //    GCHandle gch = GCHandle.Alloc(o, GCHandleType.Pinned);
        //    IntPtr pObj = gch.AddrOfPinnedObject();
        //    return pObj;
        //}

        public static long Get(Object o)
        {
            GCHandle gch = GCHandle.Alloc(o, GCHandleType.Pinned);
            IntPtr pObj = gch.AddrOfPinnedObject();
            return (long)pObj;
        }

        //public static string Get(Object o)
        //{
        //    GCHandle gch = GCHandle.Alloc(o, GCHandleType.Pinned);
        //    IntPtr pObj = gch.AddrOfPinnedObject();
        //    return $"The address is: {(long)pObj}";
        //}



    }

}