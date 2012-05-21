using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Memory allocator for video frames
	/// </summary>
	[ComImport]
	[Guid("B36EB6E7-9D29-4AA8-92EF-843B87A289E8")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkMemoryAllocator
	{
		int AllocateBuffer([In] ulong bufferSize, [Out] IntPtr allocatedBuffer);
		int ReleaseBuffer([In] IntPtr buffer);

		int Commit();
		int Decommit();
	}
}
