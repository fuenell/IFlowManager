using FlowManager;
using UnityEngine;

public enum EcologyFlowType { Null, Dictionary, Wait, Tutorial, Game }

public class EcologyFlowManager : MonoBehaviour, IFlowManager<EcologyFlowType>
{
    private IFlow m_CurrentFlow;
    private EcologyFlowType m_CurrentFlowType;
    public EcologyFlowType CurrentFlowType => m_CurrentFlowType;

    [SerializeField] private AgeContentFlow m_DictionaryFlow;
    [SerializeField] private SimpleContentFlow m_WaitFlow;
    [SerializeField] private AgeContentFlow m_TutorialFlow;
    [SerializeField] private AgePlayerContentFlow m_GameFlow;

    private void Awake()
    {
        m_CurrentFlowType = EcologyFlowType.Null;
    }

    public void ChangeFlow(EcologyFlowType type)
    {
        m_CurrentFlow?.Exit();
        m_CurrentFlow = GetFlow(type);
        m_CurrentFlowType = type;
        m_CurrentFlow?.Enter();
    }

    private IFlow GetFlow(EcologyFlowType type)
    {
        switch (type)
        {
            case EcologyFlowType.Dictionary:
                return m_DictionaryFlow;
            case EcologyFlowType.Wait:
                return m_WaitFlow;
            case EcologyFlowType.Tutorial:
                return m_TutorialFlow;
            case EcologyFlowType.Game:
                return m_GameFlow;
            default:
                break;
        }

        return null;
    }
}
