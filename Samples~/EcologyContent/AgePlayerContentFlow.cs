using FlowManager;
using UnityEngine;

public class AgePlayerContentFlow : MonoBehaviour, Flow
{
    [SerializeField] private Net_Data m_Data;

    public void Enter()
    {
        string age = m_Data.GetInitData().age;
        PlayerData playerData = m_Data.GetPlayerData();

    }

    public void Exit()
    {

    }
}
