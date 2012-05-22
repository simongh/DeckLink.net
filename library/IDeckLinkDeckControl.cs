using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	/// <summary>
	/// Deck Control main interface
	/// </summary>
	[ComImport]
	[Guid("8E1C3ACE-19C7-4E00-8B92-D80431D958BE")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkDeckControl
	{
		int Open([In] long timeScale, [In] long timeValue, [In] bool timecodeIsDropFrame, [Out] out BMDDeckControlError error);
		int Close([In] bool standbyOn);
		int GetCurrentState([Out] out BMDDeckControlMode mode, [Out] out BMDDeckControlVTRControlState vtrControlState, [Out] out BMDDeckControlStatusFlags flags);
		int SetStandby([In] bool standbyOn);
		int SendCommand([In] byte inBuffer, [In] uint inBufferSize, [Out] out byte outBuffer, [Out] uint outDataSize, [In] uint outBufferSize, [Out] out BMDDeckControlError error);
		int Play([Out] out BMDDeckControlError error);
		int Stop([Out] out BMDDeckControlError error);
		int TogglePlayStop([Out] out BMDDeckControlError error);
		int Eject([Out] out BMDDeckControlError error);
		int GoToTimecode([In] uint timecode, [Out] out BMDDeckControlError error);
		int FastForward([In] bool viewTape, [Out] out BMDDeckControlError error);
		int Rewind([In] bool viewTape, [Out] out BMDDeckControlError error);
		int StepForward([Out] out BMDDeckControlError error);
		int StepBack([Out] out BMDDeckControlError error);
		int Jog([In] double rate, [Out] out BMDDeckControlError error);
		int Shuttle([In] double rate, [Out] out BMDDeckControlError error);
		int GetTimecodeString([Out, MarshalAs(UnmanagedType.BStr)] out string currentTimeCode, [Out] out BMDDeckControlError error);
		int GetTimecode([Out] out IDeckLinkTimecode currentTimecode, [Out] out BMDDeckControlError error);
		int GetTimecodeBCD([Out] out uint currentTimecode, [Out] out BMDDeckControlError error);
		int SetPreroll([In] uint prerollSeconds);
		int GetPreroll([Out] out uint prerollSeconds);
		int SetExportOffset([In] int exportOffsetFields);
		int GetExportOffset([Out] out int exportOffsetFields);
		int GetManualExportOffset([Out] out int deckManualExportOffsetFields);
		int SetCaptureOffset([In] int captureOffsetFields);
		int GetCaptureOffset([Out] out int captureOffsetFields);
		int StartExport([In] uint inTimecode, [In] uint outTimecode, [In] BMDDeckControlExportModeOpsFlags exportModeOps, [Out] out BMDDeckControlError error);
		int StartCapture([In] bool useVITC, [In] int inTimecode, [In] int outTimecode, [Out] out BMDDeckControlError error);
		int GetDeviceID([Out] out ushort deviceId, [Out] out BMDDeckControlError error);
		int Abort();
		int CrashRecordStart([Out] out BMDDeckControlError error);
		int CrashRecordStop([Out] out BMDDeckControlError error);
		int SetCallback([In] IDeckLinkDeckControlStatusCallback callback);
	}
}
