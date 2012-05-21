using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Optional callback to allow audio samples to be pulled as required
	/// </summary>
	[ComImport]
	[Guid("403C681B-7F46-4A12-B993-2BB127084EE6")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkAudioOutputCallback
	{
		int RenderAudioSamples([In] bool preroll);
	}
}
