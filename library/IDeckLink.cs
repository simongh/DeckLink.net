using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Blackmagic.DeckLink
{
	[ComImport]
	[Guid("C418FBDD-0587-48ED-8FE5-640F0A14AF91")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface IDeckLink
	{
		int GetModelName([Out, MarshalAs(UnmanagedType.BStr)] out string modelName);
		int GetDisplayName([Out, MarshalAs(UnmanagedType.BStr)] out string displayName);
	}
}
