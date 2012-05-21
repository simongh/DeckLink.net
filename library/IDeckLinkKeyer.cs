using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// DeckLink Keyer interface
	/// </summary>
	[ComImport]
	[Guid("89AFCAF5-65F8-421E-98F7-96FE5F5BFBA3")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkKeyer
	{
		int Enable([In] bool isExternal);
		int SetLevel([In] byte level);
		int RampUp([In] uint numberOfFrames);
		int RampDown([In] uint numberOfFrames);
		int Disable();
	}
}
