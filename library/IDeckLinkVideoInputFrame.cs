using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Provided by the IDeckLinkVideoInput frame arrival callback
	/// </summary>
	[ComImport]
	[Guid("05CFE374-537C-4094-9A57-680525118F44")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkVideoInputFrame
	{
		int GetStreamTime([Out] out long frameTime, [Out] out long frameDuration, [In] long timeScale);
		int GetHardwareReferenceTimestamp([In] long timeScale, [Out] out long frameTime, [Out] out long frameDuration);
	}
}
