using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices
{
	public partial struct GCHandle
	{
		private static bool CheckCurrentDomain (int handle)
		{
			throw new System.NotImplementedException();
		}
		private static object GetTarget(int handle)
		{
			throw new System.NotImplementedException();
		}
		private static int GetTargetHandle(object obj, int handle, GCHandleType type)
		{
			throw new System.NotImplementedException();
		}
		private static void FreeHandle(int handle)
		{
			throw new System.NotImplementedException();
		}
		private static IntPtr GetAddrOfPinnedObject(int handle)
		{
			throw new System.NotImplementedException();
		}

	}
}
