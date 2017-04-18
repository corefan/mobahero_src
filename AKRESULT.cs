using System;

public enum AKRESULT
{
	AK_NotImplemented,
	AK_Success,
	AK_Fail,
	AK_PartialSuccess,
	AK_NotCompatible,
	AK_AlreadyConnected,
	AK_NameNotSet,
	AK_InvalidFile,
	AK_AudioFileHeaderTooLarge,
	AK_MaxReached,
	AK_InputsInUsed,
	AK_OutputsInUsed,
	AK_InvalidName,
	AK_NameAlreadyInUse,
	AK_InvalidID,
	AK_IDNotFound,
	AK_InvalidInstanceID,
	AK_NoMoreData,
	AK_NoSourceAvailable,
	AK_StateGroupAlreadyExists,
	AK_InvalidStateGroup,
	AK_ChildAlreadyHasAParent,
	AK_InvalidLanguage,
	AK_CannotAddItseflAsAChild,
	AK_UserNotInList = 29,
	AK_NoTransitionPoint,
	AK_InvalidParameter,
	AK_ParameterAdjusted,
	AK_IsA3DSound,
	AK_NotA3DSound,
	AK_ElementAlreadyInList,
	AK_PathNotFound,
	AK_PathNoVertices,
	AK_PathNotRunning,
	AK_PathNotPaused,
	AK_PathNodeAlreadyInList,
	AK_PathNodeNotInList,
	AK_VoiceNotFound,
	AK_DataNeeded,
	AK_NoDataNeeded,
	AK_DataReady,
	AK_NoDataReady,
	AK_NoMoreSlotAvailable,
	AK_SlotNotFound,
	AK_ProcessingOnly,
	AK_MemoryLeak,
	AK_CorruptedBlockList,
	AK_InsufficientMemory,
	AK_Cancelled,
	AK_UnknownBankID,
	AK_IsProcessing,
	AK_BankReadError,
	AK_InvalidSwitchType,
	AK_VoiceDone,
	AK_UnknownEnvironment,
	AK_EnvironmentInUse,
	AK_UnknownObject,
	AK_NoConversionNeeded,
	AK_FormatNotReady,
	AK_WrongBankVersion,
	AK_DataReadyNoProcess,
	AK_FileNotFound,
	AK_DeviceNotReady,
	AK_CouldNotCreateSecBuffer,
	AK_BankAlreadyLoaded,
	AK_RenderedFX = 71,
	AK_ProcessNeeded,
	AK_ProcessDone,
	AK_MemManagerNotInitialized,
	AK_StreamMgrNotInitialized,
	AK_SSEInstructionsNotSupported,
	AK_Busy,
	AK_UnsupportedChannelConfig,
	AK_PluginMediaNotAvailable,
	AK_MustBeVirtualized,
	AK_CommandTooLarge,
	AK_RejectedByFilter,
	AK_InvalidCustomPlatformName
}
