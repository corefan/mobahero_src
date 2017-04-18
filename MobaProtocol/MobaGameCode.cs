using System;

namespace MobaProtocol
{
	public enum MobaGameCode : byte
	{
		Login = 1,
		GetRoomInfo,
		GetAllRoomInfo,
		JoinRoom,
		QuitRoom,
		LoginByChannelId,
		RoomActorBorning,
		RoomActorActionUpdate,
		RoomSpeak,
		Register,
		Logout,
		ModfiyNickName,
		ModfiyAvatar,
		ModfiyPictureFrame,
		ExchangeByDimond,
		SweepBattle,
		RestTodayBattlesCount,
		ReconnectToGameServer,
		MagicBottleItem,
		LuckyDrawState,
		LuckyDraw,
		DischargeRune,
		SetPushState,
		GetKdaMyHeroData,
		GetDiscountCard,
		GetShopVersion,
		ShowIconFrame,
		AppStoreCharge,
		GetShopNew,
		GetTaskList,
		CompleteTask,
		CompleteTaskMessage,
		Attendance,
		BuyShopGoodsNew,
		SignDay,
		CreateUnion,
		DissolveUnion,
		SearchUnion,
		JoinUnion,
		KickUnion,
		VipAttendance,
		LeaveUnion,
		ModifyUnionSetting,
		ModifyAnnouncement,
		GetUnionList,
		GetUnionLogs,
		GetMemberList,
		AppointElder,
		UnAppointElder,
		GetUnionRequestList,
		DisposeUnionRequest,
		GetUnionInfo,
		UpgradeMaster,
		GetSmallMeleeInfo,
		UpdateSmallMeleeTeam,
		ResetSmallMelee,
		ClearSmallMeleeCDTime,
		GetSmallMeleeLogs,
		RefreshSmallMelee,
		GetSmallMeleeReward,
		GetTalentInfo,
		GetTalentInfoByUid,
		InitRobotData,
		DealGameReport,
		RichManGiftMgr,
		GetRedPacketsInfo,
		GetRedPackets,
		GetPlayerData = 69,
		GetUserId,
		ReBindGame,
		OneKeyCompose,
		GetFriendMessages,
		SendPrivateMessage,
		GetUserInfoBySummId,
		TeamRoomOperation,
		GetSummonerLadderRankList = 79,
		ReceiveMailAttachment,
		GetMailList,
		GetMailNotice,
		ModifyEmailState,
		CompleteNewerGuide,
		ChangeSummonerSKill,
		ModifyMyState,
		GetArenaEnemyInfoByUserId,
		InviteManger,
		ExchangeChip,
		Leave,
		RaiseEvent,
		SetProperties,
		GetProperties,
		GetPvpFightResult,
		GetSummSkinList,
		ClientReportOnlineTime,
		ShowDailyTask,
		GetAchieveTaskAward,
		GetFriendGameServer,
		GetGameServer,
		GetDailyTaskAward,
		GetMyFightAbility,
		SaveUserHonorPic,
		SearchUser,
		RequestFriend,
		AcceptFriend,
		InviteFriend,
		AccessFriend,
		AddFriend,
		DeleteFriend,
		FriendList,
		Feedback,
		SyncDate,
		QuickStart,
		JoinTable,
		LeaveTable,
		BroadcastMessage,
		BroadcastMessageInTable,
		Sit,
		SaveUserInfo,
		GetUserHonorPic,
		Fold,
		Call,
		Raise,
		Check,
		HistoryAction,
		RequestRobot,
		BuyItem,
		SendChip,
		SendGift,
		StandUp,
		ShareGame,
		Suspend,
		Achieve,
		QueryUserById,
		Setting,
		GuestUpgrade,
		SystemNotice,
		TryJoinTable,
		PublishInGame,
		RecordSpeechTime,
		SyncGameData,
		GetAward,
		GetOnlineAwards,
		GetUserProps,
		BuyitemByChips,
		KickPlayer,
		GetSummonersData,
		GetOnlinePeopleNum,
		SayGoodToSomeOne,
		AddTakenMoney,
		RestartGame,
		QuickLeaveTable,
		GameGrades,
		JoinCareerGame,
		Latency,
		ExchangeKeysForEncryption,
		ResourceUrl,
		GetSignDay,
		GetMagicBottleInfo,
		DrawMagicBottleAward,
		CloseMagicBottleDraw,
		GetMagicBottleRankList,
		GetTotalRecord,
		GetHistoryRecord,
		GetHomeTotalRecord,
		GetHeroRecordInfo,
		QueryRoomState,
		GetDoubleCard,
		GetChargeInfo,
		GetCurrencyCount,
		GetActivityTask,
		GetActivityAward,
		GetNoticeBoard,
		GameReport = 197,
		NotUsedId198,
		TeachingGuide,
		GetHeroList,
		HeroAdvance,
		Enchant,
		SellProps,
		Coalesce,
		GetEquipmentList,
		UsingEquipment,
		GetEquipmentDrop,
		UploadFightResult,
		UseSoulstone,
		UseProps,
		GetTalent,
		ChangeTalent,
		BuyTalentPag,
		ModfiyTalentPag,
		RestTalentPag,
		GetRune,
		ChangeRune,
		BuyRunePag,
		ModfiyRunePag,
		GetBattles,
		BuySkillPoint,
		UsingSkillPoint,
		DebugGame,
		CancelJoinRandomGame,
		JoinRandomGame,
		JoinGame,
		CreateGame,
		LeaveLobby,
		JoinLobby,
		WearPrivateEffect,
		CheckUnlockBattle,
		UpdateDefFight,
		GetTBCEnemyInfo,
		RestTBCEnemyInfo,
		SaveTBCEnemyInfo,
		TBCMyHeroStateInfo,
		ReceiveTBCReward,
		UpdateArenaDefTeam,
		GetArenaDefTeam,
		GetArenaEnemyInfo,
		ArenaAtcCheck,
		UploadArenaAtc,
		ArenaFightLog,
		GetArenaState,
		RestArenaCount,
		RestArenaCD,
		ArenaRank,
		PvpJoin,
		MedalNotice,
		GetMedalData,
		GetMyArenaRank,
		GetArenaRankList,
		ChangCurrentTips,
		GetCharmRankList,
		ChangeSkin,
		ChangeGroups = 248
	}
}
