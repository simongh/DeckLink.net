using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Represents a chunk of audio data
	/// </summary>
	[ComImport]
	[Guid("D9EB5902-1AD2-43F4-9E2C-3CFA50B5EE19")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingAudioPacket
	{
		BMDStreamingAudioCodec GetCodec();
		long GetPayloadSize();
		int GetBytes([Out] out IntPtr buffer);
		int GetPlayTime([In] long requestedTimeScale, [Out] out long playTime);
		int GetPacketIndex([Out]  out int packetIndex);
	}
}
