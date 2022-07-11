using FlowManager;
using UnityEngine;

public class AgeContentFlow : MonoBehaviour, Flow
{
    [SerializeField] private Net_Data m_Data;

    [SerializeField] private GameObject m_AgeObject5;
    [SerializeField] private GameObject m_AgeObject6;
    [SerializeField] private GameObject m_AgeObject7;

    private void Awake()
    {
        Exit();
    }

    public void Enter()
    {
        string age = m_Data.GetInitData().age;

        switch (age)
        {
            case "5":
                m_AgeObject5.SetActive(true);
                break;
            case "6":
                m_AgeObject6.SetActive(true);
                break;
            case "7":
                m_AgeObject7.SetActive(true);
                break;
        }
    }

    public void Exit()
    {
        m_AgeObject5.SetActive(false);
        m_AgeObject6.SetActive(false);
        m_AgeObject7.SetActive(false);
    }
}
