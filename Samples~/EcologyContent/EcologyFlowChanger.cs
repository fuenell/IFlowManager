using UnityEngine;

public class EcologyFlowChanger : MonoBehaviour
{
    [SerializeField] private string m_GameCode;
    [SerializeField] private Net_Data m_Data;
    [SerializeField] private EcologyFlowManager m_EcologyFlowManager;

    // 초기화 데이터 입력 (프로그램 초기화)
    public void OnReceiveCA()
    {
        InitData initData = m_Data.GetInitData();
        if (initData != null && m_GameCode == initData.Code)
        {
            m_EcologyFlowManager.ChangeFlow(EcologyFlowType.Dictionary);
        }
    }

    // 플레이어 데이터 입력 (튜토리얼로 이동)
    public void OnReceivePD()
    {
        // 현재 상태가 Wait 또는 Tutorial 또는 Game 일 때 
        if (IsCurrentFlow(EcologyFlowType.Wait, EcologyFlowType.Tutorial, EcologyFlowType.Game))
        {
            ResetGame();
        }
    }

    // 도감 닫기 (튜토리얼로 이동)
    public void OnCloseDictionary()
    {
        if (IsCurrentFlow(EcologyFlowType.Dictionary))
        {
            SoundManager.Instance.PlaySound("diction_click");
            ResetGame();
        }
    }

    // 플레이어 데이터 확인 후 튜토리얼로 이동 (게임 초기화)
    private void ResetGame()
    {
        PlayerData playerData = m_Data.GetPlayerData();

        if (playerData != null && 0 < playerData.player.Count)
        {
            m_EcologyFlowManager.ChangeFlow(EcologyFlowType.Tutorial);
        }
        else
        {
            m_EcologyFlowManager.ChangeFlow(EcologyFlowType.Wait);
        }
    }

    // 튜토리얼 닫기 (게임 시작)
    public void OnCloseTutorial()
    {
        if (IsCurrentFlow(EcologyFlowType.Tutorial))
        {
            SoundManager.Instance.PlaySound("diction_click");
            m_EcologyFlowManager.ChangeFlow(EcologyFlowType.Game);
        }
    }

    // 현재 상태 검사
    private bool IsCurrentFlow(params EcologyFlowType[] types)
    {
        foreach (EcologyFlowType type in types)
        {
            if (m_EcologyFlowManager.CurrentFlowType == type)
            {
                return true;
            }
        }

        return false;
    }
}
