using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Represent an MPEG2 Transport Stream packet
	/// </summary>
	[ComImport]
	[Guid("91810D1C-4FB3-4AAA-AE56-FA301D3DFA4C")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingMPEG2TSPacket
	{
		int GetPayloadSize();
		int GetBytes([Out] out IntPtr buffer);
	}
}
