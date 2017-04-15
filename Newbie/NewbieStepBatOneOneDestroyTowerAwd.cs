using Com.Game.Module;
using System;
using UnityEngine;

namespace Newbie
{
	public class NewbieStepBatOneOneDestroyTowerAwd : NewbieStepBase
	{
		private string _voiceResId = "2036";

		public NewbieStepBatOneOneDestroyTowerAwd()
		{
			this._stepType = ENewbieStepType.ElementaryBatOneOne_DestroyTowerAwd;
		}

		public override void OnLeave()
		{
			NewbieManager.Instance.StopVoiceHintOnce();
			Singleton<NewbieView>.Instance.HidePlayNiceEffect();
			Singleton<NewbieView>.Instance.HideMask();
			CtrlManager.CloseWindow(WindowID.NewbieView);
		}

		public override void HandleAction()
		{
			CtrlManager.OpenWindow(WindowID.NewbieView, null);
			Singleton<NewbieView>.Instance.SetMaskInfo(true, new Color(0.5f, 0.5f, 0.5f, 0.01f));
			Singleton<NewbieView>.Instance.ShowPlayNiceEffect();
			NewbieManager.Instance.HideMoveGuideLine();
			NewbieManager.Instance.DestroyEffectObstacleByIdx(4);
			NewbieManager.Instance.PlayVoiceHintOnce(this._voiceResId);
			CtrlManager.CloseWindow(WindowID.BattleEquipmentView);
			CtrlManager.CloseWindow(WindowID.StatisticView);
			base.AutoMoveNextStepWithDelay(3f);
		}
	}
}
