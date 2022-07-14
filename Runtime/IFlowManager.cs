namespace FlowManager
{
    public interface IFlowManager<T>
    {
        T CurrentFlowType { get; }
        void ChangeFlow(T type);
    }

    public interface IFlow
    {
        void Enter();
        void Exit();
    }
}