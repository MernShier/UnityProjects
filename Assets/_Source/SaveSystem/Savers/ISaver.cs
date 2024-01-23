namespace SaveSystem.Savers
{
    public interface ISaver
    {
        void Save(SaveData saveData);
        SaveData Load();
    }
}
