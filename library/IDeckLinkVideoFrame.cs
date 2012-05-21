using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Interface to encapsulate a video frame; can be caller-implemented
	/// </summary>
	[ComImport]
	[Guid("3F716FE0-F023-4111-BE5D-EF4414C05B17")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkVideoFrame
	{
		int GetWidth();
		int GetHeight();
		int GetRowBytes();
		BMDPixelFormat GetPixelFormat();
		BMDFrameFlags GetFlags();
		int GetBytes([Out] out IntPtr buffer);

		int GetTimecode([In] BMDTimecodeFormat format, [Out] out IDeckLinkTimecode timecode);
		int GetAncillaryData([Out] out IDeckLinkVideoFrameAncillary ancillary);
	}
}
