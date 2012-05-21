using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// enumerates installed DeckLink hardware
	/// </summary>
	[ComImport]
	[Guid("50FB36CD-3063-4B73-BDBB-958087F2D8BA")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkIterator
	{
		int Next([Out] out IDeckLink deckLinkInstance);
	}
}
