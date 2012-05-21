using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Enumerates encoding mode presets
	/// </summary>
	[ComImport]
	[Guid("7AC731A3-C950-4AD0-804A-8377AA51C6C4")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingVideoEncodingModePresetIterator
	{
		int Next([Out] IBMDStreamingVideoEncodingMode videoEncodingMode);
	}
}
