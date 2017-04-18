using Com.Game.Data;
using System;
using System.Collections.Generic;

namespace Com.Game.Manager
{
	public class BaseDataConst
	{
		public static Dictionary<string, Type> registerClzType()
		{
			return new Dictionary<string, Type>
			{
				{
					"SysAiConfigVo",
					typeof(SysAiConfigVo)
				},
				{
					"SysAttendanceRewardsVo",
					typeof(SysAttendanceRewardsVo)
				},
				{
					"SysBattleAttrLvVo",
					typeof(SysBattleAttrLvVo)
				},
				{
					"SysBattleConfigVo",
					typeof(SysBattleConfigVo)
				},
				{
					"SysBattleMonsterCreepVo",
					typeof(SysBattleMonsterCreepVo)
				},
				{
					"SysBattleRefreshVo",
					typeof(SysBattleRefreshVo)
				},
				{
					"SysBattleSceneVo",
					typeof(SysBattleSceneVo)
				},
				{
					"SysCurrencyVo",
					typeof(SysCurrencyVo)
				},
				{
					"SysGameItemsVo",
					typeof(SysGameItemsVo)
				},
				{
					"SysGameResVo",
					typeof(SysGameResVo)
				},
				{
					"SysGuildLogVo",
					typeof(SysGuildLogVo)
				},
				{
					"SysGuildVo",
					typeof(SysGuildVo)
				},
				{
					"SysHeroMainVo",
					typeof(SysHeroMainVo)
				},
				{
					"SysMailInfoVo",
					typeof(SysMailInfoVo)
				},
				{
					"SysMonsterMainVo",
					typeof(SysMonsterMainVo)
				},
				{
					"SysPromptVo",
					typeof(SysPromptVo)
				},
				{
					"SysRankStageVo",
					typeof(SysRankStageVo)
				},
				{
					"SysServerNameVo",
					typeof(SysServerNameVo)
				},
				{
					"SysSkillBuffVo",
					typeof(SysSkillBuffVo)
				},
				{
					"SysSkillDamageVo",
					typeof(SysSkillDamageVo)
				},
				{
					"SysSkillFormulaVo",
					typeof(SysSkillFormulaVo)
				},
				{
					"SysSkillHigheffVo",
					typeof(SysSkillHigheffVo)
				},
				{
					"SysSkillMainVo",
					typeof(SysSkillMainVo)
				},
				{
					"SysSkillLevelupVo",
					typeof(SysSkillLevelupVo)
				},
				{
					"SysSkillSkinVo",
					typeof(SysSkillSkinVo)
				},
				{
					"SysSkillPerformVo",
					typeof(SysSkillPerformVo)
				},
				{
					"SysSkillUnitVo",
					typeof(SysSkillUnitVo)
				},
				{
					"SysSummonersGivingVo",
					typeof(SysSummonersGivingVo)
				},
				{
					"SysSummonersHeadportraitVo",
					typeof(SysSummonersHeadportraitVo)
				},
				{
					"SysSummonersLevelVo",
					typeof(SysSummonersLevelVo)
				},
				{
					"SysSummonersNameVo",
					typeof(SysSummonersNameVo)
				},
				{
					"SysSummonersPictureframeVo",
					typeof(SysSummonersPictureframeVo)
				},
				{
					"SysSummonersTopupVo",
					typeof(SysSummonersTopupVo)
				},
				{
					"SysMedalVo",
					typeof(SysMedalVo)
				}
			};
		}
	}
}
