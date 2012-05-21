using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Deck control state change callback
	/// </summary>
	[ComImport]
	[Guid("53436FFB-B434-4906-BADC-AE3060FFE8EF")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkDeckControlStatusCallback
	{
		int TimecodeUpdate([In] int currentTimecode);
		int VTRControlStateChanged([In] BMDDeckControlVTRControlState newState, [In] BMDDeckControlError error);
		int DeckControlEventReceived([In] BMDDeckControlEvent @event, [In] BMDDeckControlError error);
		int DeckControlStatusChanged([In] BMDDeckControlStatusFlags flags, [In] int mask);
	}
}
