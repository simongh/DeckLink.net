using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Created by QueryInterface from IDeckLink
	/// </summary>
	[ComImport]
	[Guid("A3EF0963-0862-44ED-92A9-EE89ABF431C7")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkOutput
	{
		int DoesSupportVideoMode([In] BMDDisplayMode displayMode, [In] BMDPixelFormat pixelFormat, [In] BMDVideoOutputFlags flags, [Out] out BMDDisplayModeSupport result, [Out] out IDeckLinkDisplayMode resultDisplayMode);
		int GetDisplayModeIterator([Out] out IDeckLinkDisplayModeIterator iterator);

		int SetScreenPreviewCallback([In] IDeckLinkScreenPreviewCallback previewCallback);

		/* Video Output */

		int EnableVideoOutput([In] BMDDisplayMode displayMode, [In] BMDVideoOutputFlags flags);
		int DisableVideoOutput();

		int SetVideoOutputFrameMemoryAllocator([In] IDeckLinkMemoryAllocator theAllocator);
		int CreateVideoFrame([In] int width, [In] int height, [In] int rowBytes, [In] BMDPixelFormat pixelFormat, [In] BMDFrameFlags flags, [Out] out IDeckLinkMutableVideoFrame outFrame);
		int CreateAncillaryData([In] BMDPixelFormat pixelFormat, [Out] out IDeckLinkVideoFrameAncillary outBuffer);

		int DisplayVideoFrameSync([In] IDeckLinkVideoFrame theFrame);
		int ScheduleVideoFrame([In] IDeckLinkVideoFrame theFrame, [In] int displayTime, [In] int displayDuration, [In] int timeScale);
		int SetScheduledFrameCompletionCallback([In] IDeckLinkVideoOutputCallback theCallback);
		int GetBufferedVideoFrameCount([Out] out uint bufferedFrameCount);

		/* Audio Output */

		int EnableAudioOutput([In] BMDAudioSampleRate sampleRate, [In] BMDAudioSampleType sampleType, [In] uint channelCount, [In] BMDAudioOutputStreamType streamType);
		int DisableAudioOutput();

		int WriteAudioSamplesSync([In] IntPtr buffer, [In] uint sampleFrameCount, [Out] out uint sampleFramesWritten);

		int BeginAudioPreroll();
		int EndAudioPreroll();
		int ScheduleAudioSamples([In] IntPtr buffer, [In] uint sampleFrameCount, [In] int streamTime, [In] int timeScale, [Out] out uint sampleFramesWritten);

		int GetBufferedAudioSampleFrameCount([Out] out uint bufferedSampleFrameCount);
		int FlushBufferedAudioSamples();

		int SetAudioCallback([In] IDeckLinkAudioOutputCallback theCallback);

		/* Output Control */

		int StartScheduledPlayback([In] int playbackStartTime, [In] int timeScale, [In] double playbackSpeed);
		int StopScheduledPlayback([In] int stopPlaybackAtTime, [Out] out int actualStopTime, [In] int timeScale);
		int IsScheduledPlaybackRunning([Out] out bool active);
		int GetScheduledStreamTime([In] int desiredTimeScale, [Out] out int streamTime, [Out] out double playbackSpeed);
		int GetReferenceStatus([Out] out BMDReferenceStatus referenceStatus);

		/* Hardware Timing */

		int GetHardwareReferenceClock([In] int desiredTimeScale, [Out] out int hardwareTime, [Out] out int timeInFrame, [Out] out int ticksPerFrame);
	}
}
