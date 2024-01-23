namespace SaveSystem
{
    public interface ISaveDataUserController
    {
        void AddSaveDataUser(ISaveDataUser saveDataUser);
        void RemoveSaveDataUser(ISaveDataUser saveDataUser);
        void SaveAllUsersData();
        void LoadAllUsersData();
    }
}