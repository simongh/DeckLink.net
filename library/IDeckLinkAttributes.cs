using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// DeckLink Attribute interface
	/// </summary>
	[ComImport]
	[Guid("ABC11843-D966-44CB-96E2-A1CB5D3135C4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkAttributes
	{
		int GetFlag([In] BMDDeckLinkAttributeID cfgID, [Out] out bool value);
		int GetInt([In] BMDDeckLinkAttributeID cfgID, [Out] out long value);
		int GetFloat([In] BMDDeckLinkAttributeID cfgID, [Out] out double value);
		int GetString([In] BMDDeckLinkAttributeID cfgID, [Out, MarshalAs(UnmanagedType.BStr)] string value);
	}
}
