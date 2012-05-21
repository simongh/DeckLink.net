using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Frame completion callback
	/// </summary>
	[ComImport]
	[Guid("20AA5225-1958-47CB-820B-80A8D521A6EE")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkVideoOutputCallback
	{
		int ScheduledFrameCompleted([In] IDeckLinkVideoFrame completedFrame, [In] BMDOutputFrameCompletionResult result);
		int ScheduledPlaybackHasStopped();
	}
}
