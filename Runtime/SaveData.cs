public class SaveData
{
    private static SaveData m_Instance = new SaveData();
    public static SaveData Instance
    {
        get
        {
            if (m_Instance == null)
            {
                m_Instance = new SaveData();
            }

            return m_Instance;
        }
        set { m_Instance = value; }
    }
}
