using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Screen preview callback
	/// </summary>
	[ComImport]
	[Guid("B1D3F49A-85FE-4C5D-95C8-0B5D5DCCD438")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkScreenPreviewCallback
	{
		int DrawFrame([In] IDeckLinkVideoFrame theFrame);
	}
}
