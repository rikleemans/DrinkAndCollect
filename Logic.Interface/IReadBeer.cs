namespace Logic.Interface
{
    public interface IReadBeer
    {
       public bool UpdateBeer(int id, int styleid, int catid, string name, string description);
    }
}