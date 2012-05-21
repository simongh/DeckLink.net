using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// DeckLinkAPI attribute interface
	/// </summary>
	[ComImport]
	[Guid("7BEA3C68-730D-4322-AF34-8A7152B532A4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkAPIInformation
	{
		int GetFlag([In] BMDDeckLinkAPIInformationID cfgID, [Out] out bool value);
		int GetInt([In] BMDDeckLinkAPIInformationID cfgID, [Out] out long value);
		int GetFloat([In] BMDDeckLinkAPIInformationID cfgID, [Out] out double value);
		int GetString([In] BMDDeckLinkAPIInformationID cfgID, [Out, MarshalAs(UnmanagedType.BStr)] out string value);
	}
}
