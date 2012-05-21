using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Obtained through QueryInterface() on an IDeckLinkVideoFrame object
	/// </summary>
	[ComImport]
	[Guid("732E723C-D1A4-4E29-9E8E-4A88797A0004")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkVideoFrameAncillary
	{
		int GetBufferForVerticalBlankingLine([In] uint lineNumber, [Out] out IntPtr buffer);
		BMDPixelFormat GetPixelFormat();
		BMDDisplayMode GetDisplayMode();
	}
}
