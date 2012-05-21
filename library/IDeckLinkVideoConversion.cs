using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Created with CoCreateInstance()
	/// </summary>
	[ComImport]
	[Guid("3BBCB8A2-DA2C-42D9-B5D8-88083644E99A")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkVideoConversion
	{
		int ConvertFrame([In] IDeckLinkVideoFrame srcFrame, [In] IDeckLinkVideoFrame dstFrame);
	}
}
