using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public bool HasKey { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
    }

    public void ObtainKey()
    {
        HasKey = true;
    }

    private int initializeCount;

    public void Initialize()
    {
        initializeCount++;
        HasKey = false;
        Debug.Log($"GameManager.Initialize() - llamada {initializeCount}");

        if (initializeCount > 1)
        {
            Debug.LogError("GameManager se inicializó más de una vez.");
        }
    }
}
