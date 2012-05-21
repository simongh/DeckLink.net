using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// For basic NAL parsing
	/// </summary>
	[ComImport]
	[Guid("5867F18C-5BFA-4CCC-B2A7-9DFD140417D2")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IBMDStreamingH264NALParser
	{
		int IsNALSequenceParameterSet([In] IBMDStreamingH264NALPacket nal);
		int IsNALPictureParameterSet([In] IBMDStreamingH264NALPacket nal);
		int GetProfileAndLevelFromSPS([In] IBMDStreamingH264NALPacket nal, [Out] out int profileIdc, [Out]  out int profileCompatability, [Out] out  int levelIdc);
	}
}
