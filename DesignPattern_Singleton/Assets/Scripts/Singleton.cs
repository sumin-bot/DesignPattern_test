using UnityEngine;

public class Singleton : MonoBehaviour
{
    private static Singleton instance;
    public static Singleton Instance
    {
        get
        {
            if (instance == null) 
            {
                var obj = FindObjectOfType<Singleton>();
                if (obj != null) 
                {
                    instance = obj; 
                }
                else 
                {
                    var newObj = new
                        GameObject().AddComponent<Singleton>();
                    instance = newObj; 
                }
            }
            return instance;
        }
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}