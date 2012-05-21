using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Device notification callbacks
	/// </summary>
	[ComImport]
	[Guid("F9531D64-3305-4B29-A387-7F74BB0D0E84")]
	[InterfaceType( ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingDeviceNotificationCallback
	{
		int StreamingDeviceArrived([In] IDeckLink device);
		int StreamingDeviceRemoved([In] IDeckLink device);
		int StreamingDeviceModeChanged([In] IDeckLink device, [In] BMDStreamingDeviceMode mode);
	}
}
