using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// H264 input callbacks
	/// </summary>
	[ComImport]
	[Guid("823C475F-55AE-46F9-890C-537CC5CEDCCA")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingH264InputCallback
	{
		int H264NALPacketArrived([In] IBMDStreamingH264NALPacket nalPacket);
		int H264AudioPacketArrived([In] IBMDStreamingAudioPacket audioPacket);
		int MPEG2TSPacketArrived([In] IBMDStreamingMPEG2TSPacket tsPacket);
		int H264VideoInputConnectorScanningChanged();
		int H264VideoInputConnectorChanged();
		int H264VideoInputModeChanged();
	}
}
