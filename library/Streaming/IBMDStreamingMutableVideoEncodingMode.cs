﻿using System;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink.Streaming
{
	/// <summary>
	/// Represents a mutable encoded video mode
	/// </summary>
	[ComImport]
	[Guid("19BF7D90-1E0A-400D-B2C6-FFC4E78AD49D")]
	public interface IBMDStreamingMutableVideoEncodingMode : IBMDStreamingVideoEncodingMode
	{
		int SetSourceRect([In] uint posX, [In] uint posY, [In] uint width, [In] uint height);
		int SetDestSize([In] uint width, [In] uint height);
		int SetFlag([In] BMDStreamingEncodingModePropertyID cfgID, [In] bool value);
		int SetInt([In] BMDStreamingEncodingModePropertyID cfgID, [In] long value);
		int SetFloat([In] BMDStreamingEncodingModePropertyID cfgID, [In] double value);
		int SetString([In] BMDStreamingEncodingModePropertyID cfgID, [In, MarshalAs(UnmanagedType.BStr)] string value);
	}
}
