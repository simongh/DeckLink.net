using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// enumerates over supported input/output display modes
	/// </summary>
	[ComImport]
	[Guid("9C88499F-F601-4021-B80B-032E4EB41C35")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkDisplayModeIterator
	{
		int Next([Out] out IDeckLinkDisplayMode deckLinkDisplayMode);
	}
}
