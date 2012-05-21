using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	[ComImport]
	[Guid("BC6CFBD3-8317-4325-AC1C-1216391E9340")]
	[InterfaceType( ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLinkTimecode
	{
		int GetBCD();
		int GetComponents([Out] out byte hours, [Out]out byte minutes, [Out]out byte seconds, [Out]out byte frames);
		int GetString([Out, MarshalAs(UnmanagedType.BStr)] out string timecode);
		BMDTimecodeFlags GetFlags();
		int GetTimecodeUserBits([Out] out long userBits);
	}
}
