using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Created by QueryInterface from IDeckLink
	/// </summary>
	[ComImport]
	[Guid("24B6B6EC-1727-44BB-9818-34FF086ACF98")]
	[InterfaceType( ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingDeviceInput
	{

	/* Input modes */

	int DoesSupportVideoInputMode([In] BMDDisplayMode inputMode, [Out] out bool result);
	int GetVideoInputModeIterator([Out] out IDeckLinkDisplayModeIterator iterator);
	int SetVideoInputMode([In] BMDDisplayMode inputMode);
	int GetCurrentDetectedVideoInputMode([Out] out BMDDisplayMode detectedMode);

	/* Capture modes */

	int GetVideoEncodingMode([Out] out IBMDStreamingVideoEncodingMode encodingMode);
	int GetVideoEncodingModePresetIterator([In] BMDDisplayMode inputMode, [Out] out IBMDStreamingVideoEncodingModePresetIterator iterator);
	int DoesSupportVideoEncodingMode([In] BMDDisplayMode inputMode, [In] IBMDStreamingVideoEncodingMode encodingMode, [Out] out BMDStreamingEncodingSupport result, [Out] out IBMDStreamingVideoEncodingMode changedEncodingMode);
	int SetVideoEncodingMode([In] IBMDStreamingVideoEncodingMode encodingMode);

	/* Input control */

	int StartCapture();
	int StopCapture();
	int SetCallback([In, MarshalAs( UnmanagedType.IUnknown)] object theCallback);
	}
}
