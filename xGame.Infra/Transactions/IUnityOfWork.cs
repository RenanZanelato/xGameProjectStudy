namespace xGame.Infra.Transactions
{
    public interface IUnityOfWork
    {
        void Commit();
    }
}
