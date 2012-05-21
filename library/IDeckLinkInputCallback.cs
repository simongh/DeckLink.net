using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Frame arrival callback
	/// </summary>
	[ComImport]
	[Guid("DD04E5EC-7415-42AB-AE4A-E80C4DFC044A")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkInputCallback
	{
		int VideoInputFormatChanged([In] BMDVideoInputFormatChangedEvents notificationEvents, [In] IDeckLinkDisplayMode newDisplayMode, [In] BMDDetectedVideoInputFormatFlags detectedSignalFlags);
		int VideoInputFrameArrived([In] IDeckLinkVideoInputFrame videoFrame, [In] IDeckLinkAudioInputPacket audioPacket);
	}
}
