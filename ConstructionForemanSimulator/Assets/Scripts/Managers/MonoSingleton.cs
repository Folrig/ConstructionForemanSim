using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
    private static T instance = null;
    private static bool initialized = false;
    public static T Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType(typeof(T)) as T;
                if (instance == null)
                {
                    GameObject g = new GameObject("_" + typeof(T).ToString(), typeof(T));
                    instance = g.GetComponent<T>();
                    DontDestroyOnLoad(instance.gameObject);
                    if (initialized == false)
                    {
                        initialized = true;
                        instance.Init();
                    }
                }
            }
            return instance;
        }
    }

    public virtual void Init()
    {
        Debug.Log("MonoSingleton Init");
    }

    void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(this);
            return;
        }
        instance = this as T;
        DontDestroyOnLoad(instance.gameObject);
        if (initialized == false)
        {
            initialized = true;
            instance.Init();
        }
    }

    void OnApplicationQuit()
    {
        instance = null;
    }
}
