using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Installs device notifications
	/// </summary>
	[ComImport]
	[Guid("2C837444-F989-4D87-901A-47C8A36D096D")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingDiscovery
	{
		int InstallDeviceNotifications([In] IBMDStreamingDeviceNotificationCallback theCallback);
		int UninstallDeviceNotifications();
	}
}
