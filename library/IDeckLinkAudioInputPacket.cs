using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Provided by the IDeckLinkInput callback
	/// </summary>
	[ComImport]
	[Guid("E43D5870-2894-11DE-8C30-0800200C9A66")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkAudioInputPacket
	{
		int GetSampleFrameCount();
		int GetBytes([Out] out IntPtr buffer);
		int GetPacketTime([Out] out int packetTime, [In] int timeScale);
	}
}
