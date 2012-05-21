using System;

namespace Blackmagic.DeckLink
{
	public enum BMDTimecodeFlags
	{
		Default = 0,
		IsDropFrame = 1
	}

	[Flags]
	public enum BMDVideoConnection
	{
		Sdi = 1,
		Hdmi = 2,
		OpticalSdi = 4,
		Component = 8,
		Composite = 16,
		SVideo = 32
	}

	public enum BMDStreamingDeviceMode
	{
		Idle = 0x69646C65,
		Encoding = 0x656E636F,
		Stopping = 0x73746F70,
		Unknown = 0x6D756E6B
	}

	public enum BMDStreamingEncodingFrameRate
	{
		e50i = /* 'e50i' */ 0x65353069,
		e5994i = /* 'e59i' */ 0x65353969,
		e60i = /* 'e60i' */ 0x65363069,

		/* Progressive rates */

		e2398p = /* 'e23p' */ 0x65323370,
		e24p = /* 'e24p' */ 0x65323470,
		e25p = /* 'e25p' */ 0x65323570,
		e2997p = /* 'e29p' */ 0x65323970,
		e30p = /* 'e30p' */ 0x65333070,
		e50p = /* 'e50p' */ 0x65353070,
		e5994p = /* 'e59p' */ 0x65353970,
		e60p = /* 'e60p' */ 0x65363070
	}

	public enum BMDStreamingEncodingSupport
	{
		NotSupported = 0,
		Supported,
		SupportedWithChanges
	}

	public enum BMDStreamingVideoCodec
	{
		H264 = /* 'H264' */ 0x48323634
	}

	public enum BMDStreamingH264Profile
	{
		High = /* 'high' */ 0x68696768,
		Main = /* 'main' */ 0x6D61696E,
		Baseline = /* 'base' */ 0x62617365
	}

	/// <summary>
	/// H264 encoding level
	/// </summary>
	public enum BMDStreamingH264Level
	{
		Level12 = /* 'lv12' */ 0x6C763132,
		Level13 = /* 'lv13' */ 0x6C763133,
		Level2 = /* 'lv2 ' */ 0x6C763220,
		Level21 = /* 'lv21' */ 0x6C763231,
		Level22 = /* 'lv22' */ 0x6C763232,
		Level3 = /* 'lv3 ' */ 0x6C763320,
		Level31 = /* 'lv31' */ 0x6C763331,
		Level32 = /* 'lv32' */ 0x6C763332,
		Level4 = /* 'lv4 ' */ 0x6C763420,
		Level41 = /* 'lv41' */ 0x6C763431,
		Level42 = /* 'lv42' */ 0x6C763432
	}

	/// <summary>
	/// H264 entropy coding
	/// </summary>
	public enum BMDStreamingH264EntropyCoding
	{
		CAVLC = /* 'EVLC' */ 0x45564C43,
		CABAC = /* 'EBAC' */ 0x45424143
	}

	/// <summary>
	/// Audio codecs
	/// </summary>
	public enum BMDStreamingAudioCodec
	{
		AAC = /* 'AAC ' */ 0x41414320
	}

	/// <summary>
	/// Encoding mode properties
	/// </summary>
	public enum BMDStreamingEncodingModePropertyID
	{
		/* Integers, Video Properties */
		VideoFrameRate = /* 'vfrt' */ 0x76667274,	// Uses values of type BMDStreamingEncodingFrameRate
		VideoBitRateKbps = /* 'vbrt' */ 0x76627274,

		/* Integers, H264 Properties */
		H264Profile = /* 'hprf' */ 0x68707266,
		H264Level = /* 'hlvl' */ 0x686C766C,
		H264EntropyCoding = /* 'hent' */ 0x68656E74,

		/* Flags, H264 Properties */
		H264HasBFrames = /* 'hBfr' */ 0x68426672,

		/* Integers, Audio Properties */
		AudioCodec = /* 'acdc' */ 0x61636463,
		AudioSampleRate = /* 'asrt' */ 0x61737274,
		AudioChannelCount = /* 'achc' */ 0x61636863,
		AudioBitRateKbps = /* 'abrt' */ 0x61627274
	}

	public enum BMDDisplayMode
	{
		/* SD Modes */
		NTSC = /* 'ntsc' */ 0x6E747363,
		NTSC2398 = /* 'nt23' */ 0x6E743233,	// 3:2 pulldown
		PAL = /* 'pal ' */ 0x70616C20,
		NTSCp = /* 'ntsp' */ 0x6E747370,
		PALp = /* 'palp' */ 0x70616C70,

		/* HD 1080 Modes */
		HD1080p2398 = /* '23ps' */ 0x32337073,
		HD1080p24 = /* '24ps' */ 0x32347073,
		HD1080p25 = /* 'Hp25' */ 0x48703235,
		HD1080p2997 = /* 'Hp29' */ 0x48703239,
		HD1080p30 = /* 'Hp30' */ 0x48703330,
		HD1080i50 = /* 'Hi50' */ 0x48693530,
		HD1080i5994 = /* 'Hi59' */ 0x48693539,
		HD1080i6000 = /* 'Hi60' */ 0x48693630,	// N.B. This _really_ is 60.00 Hz.
		HD1080p50 = /* 'Hp50' */ 0x48703530,
		HD1080p5994 = /* 'Hp59' */ 0x48703539,
		HD1080p6000 = /* 'Hp60' */ 0x48703630,	// N.B. This _really_ is 60.00 Hz.

		/* HD 720 Modes */
		HD720p50 = /* 'hp50' */ 0x68703530,
		HD720p5994 = /* 'hp59' */ 0x68703539,
		HD720p60 = /* 'hp60' */ 0x68703630,

		/* 2k Modes */
		Mode2k2398 = /* '2k23' */ 0x326B3233,
		Mode2k24 = /* '2k24' */ 0x326B3234,
		Mode2k25 = /* '2k25' */ 0x326B3235,

		/* Special Modes */
		bmdModeUnknown = /* 'iunk' */ 0x69756E6B
	}

	/// <summary>
	/// Video field dominance
	/// </summary>
	public enum BMDFieldDominance
	{
		Unknown = 0,
		LowerFieldFirst = /* 'lowr' */ 0x6C6F7772,
		UpperFieldFirst = /* 'uppr' */ 0x75707072,
		ProgressiveFrame = /* 'prog' */ 0x70726F67,
		ProgressiveSegmentedFrame = /* 'psf ' */ 0x70736620
	};

	/// <summary>
	/// Video pixel formats supported for output/input
	/// </summary>
	public enum BMDPixelFormat
	{
		YUV8Bit = /* '2vuy' */ 0x32767579,
		YUV10Bit = /* 'v210' */ 0x76323130,
		ARGB8Bit = 32,
		BGRA8Bit = /* 'BGRA' */ 0x42475241,
		RGB10Bit = /* 'r210' */ 0x72323130	// Big-endian RGB 10-bit per component with SMPTE video levels (64-960). Packed as 2:10:10:10
	}

	/// <summary>
	/// Flags to describe the characteristics of an IDeckLinkDisplayMode
	/// </summary>
	[Flags]
	public enum BMDDisplayModeFlags
	{
		Supports3D = 1,
		ColorspaceRec601 = 2,
		ColorspaceRec709 = 4,
	};

	/// <summary>
	/// DeckControl mode
	/// </summary>
	public enum BMDDeckControlMode
	{
		NotOpened = /* 'ntop' */ 0x6E746F70,
		VTRControlMode = /* 'vtrc' */ 0x76747263,
		ExportMode = /* 'expm' */ 0x6578706D,
		CaptureMode = /* 'capm' */ 0x6361706D
	}

	/// <summary>
	/// DeckControl event
	/// </summary>
	public enum BMDDeckControlEvent
	{
		/// <summary>
		/// This event is triggered when a capture or edit-to-tape operation is aborted
		/// </summary>
		AbortedEvent = /* 'abte' */ 0x61627465,

		/* Export-To-Tape events */
		/// <summary>
		/// This event is triggered a few frames before reaching the in-point. IDeckLinkInput::StartScheduledPlayback() should be called at this point.
		/// </summary>
		PrepareForExportEvent = /* 'pfee' */ 0x70666565,
		/// <summary>
		/// This event is triggered a few frames after reaching the out-point. At this point, it is safe to stop playback.
		/// </summary>
		ExportCompleteEvent = /* 'exce' */ 0x65786365,

		/* Capture events */
		/// <summary>
		/// This event is triggered a few frames before reaching the in-point. The serial timecode attached to IDeckLinkVideoInputFrames is now valid.
		/// </summary>
		PrepareForCaptureEvent = /* 'pfce' */ 0x70666365,
		/// <summary>
		/// This event is triggered a few frames after reaching the out-point.
		/// </summary>
		CaptureCompleteEvent = /* 'ccev' */ 0x63636576
	}

	/// <summary>
	/// VTR Control state
	/// </summary>
	public enum BMDDeckControlVTRControlState
	{
		NotInVTRControlMode = /* 'nvcm' */ 0x6E76636D,
		Playing = /* 'vtrp' */ 0x76747270,
		Recording = /* 'vtrr' */ 0x76747272,
		Still = /* 'vtra' */ 0x76747261,
		ShuttleForward = /* 'vtsf' */ 0x76747366,
		ShuttleReverse = /* 'vtsr' */ 0x76747372,
		JogForward = /* 'vtjf' */ 0x76746A66,
		JogReverse = /* 'vtjr' */ 0x76746A72,
		Stopped = /* 'vtro' */ 0x7674726F
	}

	/// <summary>
	/// Deck Control status flags
	/// </summary>
	[Flags]
	public enum BMDDeckControlStatusFlags
	{
		DeckConnected = 1,
		RemoteMode = 2,
		RecordInhibited = 4,
		CassetteOut = 8
	};

	/// <summary>
	/// Export mode flags
	/// </summary>
	[Flags]
	public enum BMDDeckControlExportModeOpsFlags
	{
		Video = 0x001,
		Audio1 = 0x002,
		Audio2 = 0x004,
		Audio3 = 0x008,
		Audio4 = 0x010,
		Audio5 = 0x020,
		Audio6 = 0x040,
		Audio7 = 0x080,
		Audio8 = 0x100,
		Audio9 = 0x200,
		Audio10 = 0x400,
		Audio11 = 0x800,
		Audio12 = 0x1000,
		TimeCode = 0x2000,
		Assemble = 0x4000,
		Preview = 0x8000,
		UseManualExport = 0x10000
	};

	/// <summary>
	/// Deck Control error
	/// </summary>
	public enum BMDDeckControlError
	{
		NoError = /* 'noer' */ 0x6E6F6572,
		ModeError = /* 'moer' */ 0x6D6F6572,
		MissedInPoint = /* 'mier' */ 0x6D696572,
		DeckTimeout = /* 'dter' */ 0x64746572,
		CommandFailed = /* 'cfer' */ 0x63666572,
		DeviceAlreadyOpened = /* 'dalo' */ 0x64616C6F,
		FailedToOpenDevice = /* 'fder' */ 0x66646572,
		InLocalMode = /* 'lmer' */ 0x6C6D6572,
		EndOfTape = /* 'eter' */ 0x65746572,
		UserAbort = /* 'uaer' */ 0x75616572,
		NoTapeInDeck = /* 'nter' */ 0x6E746572,
		NoVideoFromCard = /* 'nvfc' */ 0x6E766663,
		NoCommunication = /* 'ncom' */ 0x6E636F6D,
		BufferTooSmall = /* 'btsm' */ 0x6274736D,
		BadChecksum = /* 'chks' */ 0x63686B73,
		UnknownError = /* 'uner' */ 0x756E6572
	}

	public enum BMDDeckLinkConfigurationID
	{
		/* Serial port Flags */
		SwapSerialRxTx = /* 'ssrt' */ 0x73737274,

		/* Video Input/Output Flags */
		Use1080pNotPsF = /* 'fpro' */ 0x6670726F,

		/* Video Input/Output Integers */
		HDMI3DPackingFormat = /* '3dpf' */ 0x33647066,
		Bypass = /* 'byps' */ 0x62797073,

		/* Audio Input/Output Flags */
		AnalogAudioConsumerLevels = /* 'aacl' */ 0x6161636C,

		/* Video output flags */
		FieldFlickerRemoval = /* 'fdfr' */ 0x66646672,
		HD1080p24ToHD1080i5994Conversion = /* 'to59' */ 0x746F3539,
		VideoOutput444SDI = /* '444o' */ 0x3434346F,
		VideoOutput3GBps = /* '3gbs' */ 0x33676273,
		BlackVideoOutputDuringCapture = /* 'bvoc' */ 0x62766F63,
		LowLatencyVideoOutput = /* 'llvo' */ 0x6C6C766F,

		/* Video Output Integers */
		VideoOutputConnection = /* 'vocn' */ 0x766F636E,
		VideoOutputConversionMode = /* 'vocm' */ 0x766F636D,
		AnalogVideoOutputFlags = /* 'avof' */ 0x61766F66,
		ReferenceInputTimingOffset = /* 'glot' */ 0x676C6F74,
		VideoOutputIdleOperation = /* 'voio' */ 0x766F696F,
		DefaultVideoOutputMode = /* 'dvom' */ 0x64766F6D,
		DefaultVideoOutputModeFlags = /* 'dvof' */ 0x64766F66,

		/* Video Output Floats */
		VideoOutputComponentLumaGain = /* 'oclg' */ 0x6F636C67,
		VideoOutputComponentChromaBlueGain = /* 'occb' */ 0x6F636362,
		VideoOutputComponentChromaRedGain = /* 'occr' */ 0x6F636372,
		VideoOutputCompositeLumaGain = /* 'oilg' */ 0x6F696C67,
		VideoOutputCompositeChromaGain = /* 'oicg' */ 0x6F696367,
		VideoOutputSVideoLumaGain = /* 'oslg' */ 0x6F736C67,
		VideoOutputSVideoChromaGain = /* 'oscg' */ 0x6F736367,

		/* Video Input Flags */
		VideoInputScanning = /* 'visc' */ 0x76697363,	// Applicable to H264 Pro Recorder only

		/* Video Input Integers */
		VideoInputConnection = /* 'vicn' */ 0x7669636E,
		AnalogVideoInputFlags = /* 'avif' */ 0x61766966,
		VideoInputConversionMode = /* 'vicm' */ 0x7669636D,
		Pulldown32SequenceInitialTimecodeFrame = /* 'pdif' */ 0x70646966,
		VANCSourceLine1Mapping = /* 'vsl1' */ 0x76736C31,
		VANCSourceLine2Mapping = /* 'vsl2' */ 0x76736C32,
		VANCSourceLine3Mapping = /* 'vsl3' */ 0x76736C33,

		/* Video Input Floats */
		VideoInputComponentLumaGain = /* 'iclg' */ 0x69636C67,
		VideoInputComponentChromaBlueGain = /* 'iccb' */ 0x69636362,
		VideoInputComponentChromaRedGain = /* 'iccr' */ 0x69636372,
		VideoInputCompositeLumaGain = /* 'iilg' */ 0x69696C67,
		VideoInputCompositeChromaGain = /* 'iicg' */ 0x69696367,
		VideoInputSVideoLumaGain = /* 'islg' */ 0x69736C67,
		VideoInputSVideoChromaGain = /* 'iscg' */ 0x69736367,

		/* Audio Input Integers */
		AudioInputConnection = /* 'aicn' */ 0x6169636E,

		/* Audio Input Floats */
		AnalogAudioInputScaleChannel1 = /* 'ais1' */ 0x61697331,
		AnalogAudioInputScaleChannel2 = /* 'ais2' */ 0x61697332,
		AnalogAudioInputScaleChannel3 = /* 'ais3' */ 0x61697333,
		AnalogAudioInputScaleChannel4 = /* 'ais4' */ 0x61697334,
		DigitalAudioInputScale = /* 'dais' */ 0x64616973,

		/* Audio Output Integers */
		AudioOutputAESAnalogSwitch = /* 'aoaa' */ 0x616F6161,

		/* Audio Output Floats */
		AnalogAudioOutputScaleChannel1 = /* 'aos1' */ 0x616F7331,
		AnalogAudioOutputScaleChannel2 = /* 'aos2' */ 0x616F7332,
		AnalogAudioOutputScaleChannel3 = /* 'aos3' */ 0x616F7333,
		AnalogAudioOutputScaleChannel4 = /* 'aos4' */ 0x616F7334,
		DigitalAudioOutputScale = /* 'daos' */ 0x64616F73
	}

	/// <summary>
	/// Flags to control the output of ancillary data along with video.
	/// </summary>
	[Flags]
	public enum BMDVideoOutputFlags
	{
		Default = 0,
		VANC = 0x01,
		VITC = 0x02,
		RP188 = 0x04,
		DualStream3D = 0x10
	}

	/// <summary>
	/// Frame flags
	/// </summary>
	[Flags]
	public enum BMDFrameFlags
	{
		Default = 0,
		FlipVertical = 1,

		/* Flags that are applicable only to instances of IDeckLinkVideoInputFrame */
		HasNoInputSource = Int32.MinValue
	};

	/// <summary>
	/// Flags applicable to video input
	/// </summary>
	[Flags]
	public enum BMDVideoInputFlags
	{
		Default = 0,
		EnableFormatDetection = 1,
		DualStream3D = 2
	};

	/// <summary>
	/// Bitmask passed to the VideoInputFormatChanged notification to identify the properties of the input signal that have changed
	/// </summary>
	[Flags]
	public enum BMDVideoInputFormatChangedEvents
	{
		DisplayModeChanged = 1,
		FieldDominanceChanged = 2,
		ColorspaceChanged = 4
	};

	/// <summary>
	/// Flags passed to the VideoInputFormatChanged notification to describe the detected video input signal
	/// </summary>
	[Flags]
	public enum BMDDetectedVideoInputFormatFlags
	{
		YCbCr422 = 1,
		RGB444 = 2
	};

	/// <summary>
	/// Frame Completion Callback
	/// </summary>
	public enum BMDOutputFrameCompletionResult
	{
		Completed,
		DisplayedLate,
		Dropped,
		Flushed
	}

	/// <summary>
	/// GenLock input status
	/// </summary>
	[Flags]
	public enum BMDReferenceStatus
	{
		NotSupportedByHardware = 1,
		Locked = 2
	}

	/// <summary>
	/// Audio sample rates supported for output/input
	/// </summary>
	public enum BMDAudioSampleRate
	{
		Rate48kHz = 48000
	}

	/// <summary>
	/// Audio sample sizes supported for output/input
	/// </summary>
	public enum BMDAudioSampleType
	{
		Integer16bit = 16,
		Integer32bit = 32
	}

	/// <summary>
	/// Audio output stream type
	/// </summary>
	public enum BMDAudioOutputStreamType
	{
		Continuous,
		ContinuousDontResample,
		Timestamped
	}

	/// <summary>
	/// Output mode supported flags
	/// </summary>
	public enum BMDDisplayModeSupport
	{
		NotSupported = 0,
		Supported,
		SupportedWithConversion
	}

	/// <summary>
	/// Timecode formats for frame metadata
	/// </summary>
	public enum BMDTimecodeFormat
	{
		/// <summary>
		/// RP188 timecode where DBB1 equals VITC1 (line 9)
		/// </summary>
		RP188VITC1 = /* 'rpv1' */ 0x72707631,
		/// <summary>
		/// RP188 timecode where DBB1 equals VITC2 (line 571)
		/// </summary>
		RP188VITC2 = /* 'rp12' */ 0x72703132,
		/// <summary>
		/// RP188 timecode where DBB1 equals LTC (line 10)
		/// </summary>
		RP188LTC = /* 'rplt' */ 0x72706C74,
		/// <summary>
		/// For capture: return the first valid timecode in {VITC1, LTC ,VITC2} - For playback: set the timecode as VITC1
		/// </summary>
		RP188Any = /* 'rp18' */ 0x72703138,
		VITC = /* 'vitc' */ 0x76697463,
		VITCField2 = /* 'vit2' */ 0x76697432,
		Serial = /* 'seri' */ 0x73657269
	}

	/// <summary>
	/// Analog video display flags
	/// </summary>
	[Flags]
	public enum BMDAnalogVideoFlags
	{
		CompositeSetup75 = 1,
		ComponentBetacamLevels = 2
	};

	/// <summary>
	/// Audio connection types
	/// </summary>
	public enum BMDAudioConnection
	{
		Embedded = /* 'embd' */ 0x656D6264,
		AESEBU = /* 'aes ' */ 0x61657320,
		Analog = /* 'anlg' */ 0x616E6C67
	}

	/// <summary>
	/// Audio output Analog/AESEBU switch
	/// </summary>
	public enum BMDAudioOutputAnalogAESSwitch
	{
		AESEBU = /* 'aes ' */ 0x61657320,
		Analog = /* 'anlg' */ 0x616E6C67
	}

	/// <summary>
	/// Video/audio conversion mode
	/// </summary>
	public enum BMDVideoOutputConversionMode
	{
		NoVideoOutputConversion = /* 'none' */ 0x6E6F6E65,
		LetterboxDown = /* 'ltbx' */ 0x6C746278,
		AnamorphicDown = /* 'amph' */ 0x616D7068,
		HD720toHD1080 = /* '720c' */ 0x37323063,
		HardwareLetterboxDown = /* 'HWlb' */ 0x48576C62,
		HardwareAnamorphicDown = /* 'HWam' */ 0x4857616D,
		HardwareCenterCutDown = /* 'HWcc' */ 0x48576363,
		Hardware720p1080pCross = /* 'xcap' */ 0x78636170,
		HardwareAnamorphic720pUp = /* 'ua7p' */ 0x75613770,
		HardwareAnamorphic1080iUp = /* 'ua1i' */ 0x75613169,
		HardwareAnamorphic149To720pUp = /* 'u47p' */ 0x75343770,
		HardwareAnamorphic149To1080iUp = /* 'u41i' */ 0x75343169,
		HardwarePillarbox720pUp = /* 'up7p' */ 0x75703770,
		HardwarePillarbox1080iUp = /* 'up1i' */ 0x75703169
	}

	/// <summary>
	/// Video input conversion mode
	/// </summary>
	public enum BMDVideoInputConversionMode
	{
		NoVideoInputConversion = /* 'none' */ 0x6E6F6E65,
		LetterboxDownFromHD1080 = /* '10lb' */ 0x31306C62,
		AnamorphicDownFromHD1080 = /* '10am' */ 0x3130616D,
		LetterboxDownFromHD720 = /* '72lb' */ 0x37326C62,
		AnamorphicDownFromHD720 = /* '72am' */ 0x3732616D,
		LetterboxUp = /* 'lbup' */ 0x6C627570,
		AnamorphicUp = /* 'amup' */ 0x616D7570
	}

	/// <summary>
	/// Video 3D packing format
	/// </summary>
	public enum BMDVideo3DPackingFormat
	{
		SidebySideHalf = /* 'sbsh' */ 0x73627368,
		LinebyLine = /* 'lbyl' */ 0x6C62796C,
		TopAndBottom = /* 'tabo' */ 0x7461626F,
		FramePacking = /* 'frpk' */ 0x6672706B,
		LeftOnly = /* 'left' */ 0x6C656674,
		RightOnly = /* 'righ' */ 0x72696768
	}

	/// <summary>
	/// Video output operation when not playing video
	/// </summary>
	public enum BMDIdleVideoOutputOperation
	{
		Black = /* 'blac' */ 0x626C6163,
		LastFrame = /* 'lafa' */ 0x6C616661,
		Desktop = /* 'desk' */ 0x6465736B
	}

	/// <summary>
	/// DeckLink Attribute ID
	/// </summary>
	public enum BMDDeckLinkAttributeID
	{
		/* Flags */
		SupportsInternalKeying = /* 'keyi' */ 0x6B657969,
		SupportsExternalKeying = /* 'keye' */ 0x6B657965,
		SupportsHDKeying = /* 'keyh' */ 0x6B657968,
		SupportsInputFormatDetection = /* 'infd' */ 0x696E6664,
		HasReferenceInput = /* 'hrin' */ 0x6872696E,
		HasSerialPort = /* 'hspt' */ 0x68737074,
		HasAnalogVideoOutputGain = /* 'avog' */ 0x61766F67,
		CanOnlyAdjustOverallVideoOutputGain = /* 'ovog' */ 0x6F766F67,
		HasVideoInputAntiAliasingFilter = /* 'aafl' */ 0x6161666C,
		HasBypass = /* 'byps' */ 0x62797073,
		SupportsDesktopDisplay = /* 'extd' */ 0x65787464,

		/* Integers */
		MaximumAudioChannels = /* 'mach' */ 0x6D616368,
		NumberOfSubDevices = /* 'nsbd' */ 0x6E736264,
		SubDeviceIndex = /* 'subi' */ 0x73756269,
		VideoOutputConnections = /* 'vocn' */ 0x766F636E,
		VideoInputConnections = /* 'vicn' */ 0x7669636E,
		DeviceBusyState = /* 'dbst' */ 0x64627374,

		/* Floats */
		VideoInputGainMinimum = /* 'vigm' */ 0x7669676D,
		VideoInputGainMaximum = /* 'vigx' */ 0x76696778,
		VideoOutputGainMinimum = /* 'vogm' */ 0x766F676D,
		VideoOutputGainMaximum = /* 'vogx' */ 0x766F6778,

		/* Strings */
		SerialPortDeviceName = /* 'slpn' */ 0x736C706E
	}

	/// <summary>
	/// DeckLinkAPI information ID
	/// </summary>
	public enum BMDDeckLinkAPIInformationID
	{
		APIVersion = /* 'vers' */ 0x76657273
	}

	/// <summary>
	/// Current device busy state
	/// </summary>
	[Flags]
	public enum BMDDeviceBusyState
	{
		Capture = 1,
		Playback = 2,
		SerialPort = 4
	};

	/// <summary>
	/// Linked Frame preview format
	/// </summary>
	public enum BMD3DPreviewFormat
	{
		Default = /* 'defa' */ 0x64656661,
		LeftOnly = /* 'left' */ 0x6C656674,
		RightOnly = /* 'righ' */ 0x72696768,
		SideBySide = /* 'side' */ 0x73696465,
		TopBottom = /* 'topb' */ 0x746F7062
	}
}
