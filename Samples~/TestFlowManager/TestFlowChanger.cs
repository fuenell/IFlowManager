using UnityEngine;

public class TestFlowChanger : MonoBehaviour
{
    [SerializeField]
    public TestFlowManager manager;

    public void SwitchFlow()
    {
        if (manager.CurrentFlowType == TestType.T1)
        {
            manager.ChangeFlow(TestType.T2);
        }
        else
        {
            manager.ChangeFlow(TestType.T1);
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SwitchFlow();
        }
    }
}
