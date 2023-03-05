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

    public static bool Save(string data)
    {
        try
        {
            //Save data method stub
        }
        catch
        {
            Console.WriteLine("Error");
            return false;
        }

        return true;
    }
    
    public static string Load()
    {
        try
        {
            //Load data method stub
        }
        catch
        {
            Console.WriteLine("Error");
            return null;
        }

        return "";
    }
}
