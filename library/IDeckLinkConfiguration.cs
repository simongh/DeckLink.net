using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// DeckLink Configuration interface
	/// </summary>
	[ComImport]
	[Guid("C679A35B-610C-4D09-B748-1D0478100FC0")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkConfiguration
	{
		int SetFlag([In] BMDDeckLinkConfigurationID cfgID, [In] bool value);
		int GetFlag([In] BMDDeckLinkConfigurationID cfgID, [Out] out bool value);
		int SetInt([In] BMDDeckLinkConfigurationID cfgID, [In] long value);
		int GetInt([In] BMDDeckLinkConfigurationID cfgID, [Out] out long value);
		int SetFloat([In] BMDDeckLinkConfigurationID cfgID, [In] double value);
		int GetFloat([In] BMDDeckLinkConfigurationID cfgID, [Out] out double value);
		int SetString([In] BMDDeckLinkConfigurationID cfgID, [In, MarshalAs(UnmanagedType.BStr)] string value);
		int GetString([In] BMDDeckLinkConfigurationID cfgID, [Out, MarshalAs(UnmanagedType.BStr)] out string value);
		int WriteConfigurationToPreferences();
	}
}
