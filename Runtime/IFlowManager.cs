namespace FlowManager
{
    public interface IFlowManager<T>
    {
        T CurrentFlowType { get; }
        void ChangeFlow(T type);
    }

    public interface Flow
    {
        void Enter();
        void Exit();
    }
}