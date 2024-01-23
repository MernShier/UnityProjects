namespace SaveSystem
{
    public interface ISaveDataUser
    {
        void Save(SaveData saveData);
        void Load(SaveData saveData);
    }
}
