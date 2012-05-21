using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Created by IDeckLinkOutput::CreateVideoFrame
	/// </summary>
	[ComImport]
	[Guid("69E2639F-40DA-4E19-B6F2-20ACE815C390")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkMutableVideoFrame
	{
		int SetFlags([In] BMDFrameFlags newFlags);

		int SetTimecode([In] BMDTimecodeFormat format, [In] IDeckLinkTimecode timecode);
		int SetTimecodeFromComponents([In] BMDTimecodeFormat format, [In] byte hours, [In] byte minutes, [In] byte seconds, [In] byte frames, [In] BMDTimecodeFlags flags);
		int SetAncillaryData([In] IDeckLinkVideoFrameAncillary ancillary);
		int SetTimecodeUserBits([In] BMDTimecodeFormat format, [In] int userBits);
	}
}
