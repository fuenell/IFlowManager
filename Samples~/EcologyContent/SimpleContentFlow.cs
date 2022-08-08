using FlowManager;
using UnityEngine;

public class SimpleContentFlow : MonoBehaviour, IFlow
{
    [SerializeField] private GameObject m_Object;

    private void Awake()
    {
        Exit();
    }

    public void Enter()
    {
        m_Object.SetActive(true);
    }

    public void Exit()
    {
        m_Object.SetActive(false);
    }
}
