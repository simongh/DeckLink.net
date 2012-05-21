using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Created with CoCreateInstance()
	/// </summary>
	[ComImport]
	[Guid("504E2209-CAC7-4C1A-9FB4-C5BB6274D22F")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkGLScreenPreviewHelper
	{
		int InitializeGL();
		int PaintGL();
		int SetFrame([In] IDeckLinkVideoFrame theFrame);
		int Set3DPreviewFormat([In] BMD3DPreviewFormat previewFormat);
	}
}
