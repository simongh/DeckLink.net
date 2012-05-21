using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Represents an encoded video mode
	/// </summary>
	[ComImport]
	[Guid("1AB8035B-CD13-458D-B6DF-5E8F7C2141D9")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingVideoEncodingMode
	{
		int GetName([Out, MarshalAs(UnmanagedType.BStr)] out string name);
		int GetPresetID();
		int GetSourcePositionX();
		int GetSourcePositionY();
		int GetSourceWidth();
		int GetSourceHeight();
		int GetDestWidth();
		int GetDestHeight();
		int GetFlag([In] BMDStreamingEncodingModePropertyID cfgID, [Out, MarshalAs(UnmanagedType.Bool)] out bool value);
		int GetInt([In] BMDStreamingEncodingModePropertyID cfgID, [Out] out int value);
		int GetFloat([In] BMDStreamingEncodingModePropertyID cfgID, [Out] out double value);
		int GetString([In] BMDStreamingEncodingModePropertyID cfgID, [Out, MarshalAs(UnmanagedType.BStr)] out string value);
		int CreateMutableVideoEncodingMode([Out] out IBMDStreamingMutableVideoEncodingMode newEncodingMode); // Creates a mutable copy of the encoding mode
	}
}
