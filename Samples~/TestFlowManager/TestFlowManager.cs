using FlowManager;
using UnityEngine;

public enum TestType { Null, T1, T2 };

public class TestFlowManager : MonoBehaviour, IFlowManager<TestType>
{
    private IFlow currentFlow;
    private TestType currentFlowType;
    public TestType CurrentFlowType { get { return currentFlowType; } }

    public TestFlow t1;
    public TestFlow t2;

    private void Start()
    {
        ChangeFlow(TestType.Null);
    }

    public void ChangeFlow(TestType type)
    {
        currentFlow?.Exit();
        currentFlow = GetFlow(type);
        currentFlowType = type;
        currentFlow?.Enter();
    }

    IFlow GetFlow(TestType type)
    {
        switch (type)
        {
            case TestType.T1:
                return t1;
            case TestType.T2:
                return t2;
        }

        return null;
    }
}
