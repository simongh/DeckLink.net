using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// represents a display mode
	/// </summary>
	[ComImport]
	[Guid("3EB2C1AB-0A3D-4523-A3AD-F40D7FB14E78")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkDisplayMode
	{
		int GetName([Out, MarshalAs(UnmanagedType.BStr)] out string name);
		BMDDisplayMode GetDisplayMode();
		int GetWidth();
		int GetHeight();
		int GetFrameRate([Out] out int frameDuration, [Out] out int timeScale);
		BMDFieldDominance GetFieldDominance();
		BMDDisplayModeFlags GetFlags();
	}
}
