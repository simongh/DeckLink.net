using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Created by QueryInterface from IDeckLink
	/// </summary>
	[ComImport]
	[Guid("AF22762B-DFAC-4846-AA79-FA8883560995")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkInput
	{
		int DoesSupportVideoMode([In] BMDDisplayMode displayMode, [In] BMDPixelFormat pixelFormat, [In] BMDVideoInputFlags flags, [Out] out BMDDisplayModeSupport result, [Out] out IDeckLinkDisplayMode resultDisplayMode);
		int GetDisplayModeIterator([Out] out IDeckLinkDisplayModeIterator iterator);

		int SetScreenPreviewCallback([In] IDeckLinkScreenPreviewCallback previewCallback);

		/* Video Input */

		int EnableVideoInput([In] BMDDisplayMode displayMode, [In] BMDPixelFormat pixelFormat, [In] BMDVideoInputFlags flags);
		int DisableVideoInput();
		int GetAvailableVideoFrameCount([Out] out uint availableFrameCount);
		int SetVideoInputFrameMemoryAllocator([In] IDeckLinkMemoryAllocator theAllocator);

		/* Audio Input */

		int EnableAudioInput([In] BMDAudioSampleRate sampleRate, [In] BMDAudioSampleType sampleType, [In] uint channelCount);
		int DisableAudioInput();
		int GetAvailableAudioSampleFrameCount([Out] out uint availableSampleFrameCount);

		/* Input Control */

		int StartStreams();
		int StopStreams();
		int PauseStreams();
		int FlushStreams();
		int SetCallback([In] IDeckLinkInputCallback theCallback);

		/* Hardware Timing */

		int GetHardwareReferenceClock([In] long desiredTimeScale, [Out] out long hardwareTime, [Out] out long timeInFrame, [Out] out long ticksPerFrame);
	}
}
