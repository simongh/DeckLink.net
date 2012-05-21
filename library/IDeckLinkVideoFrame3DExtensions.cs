using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Optional interface implemented on IDeckLinkVideoFrame to support 3D frames
	/// </summary>
	[ComImport]
	[Guid("DA0F7E4A-EDC7-48A8-9CDD-2DB51C729CD7")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkVideoFrame3DExtensions
	{
		BMDVideo3DPackingFormat Get3DPackingFormat();
		int GetFrameForRightEye([Out] out IDeckLinkVideoFrame rightEyeFrame);
	}
}
