using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private int correctCode = 1234;
    [SerializeField] private int maxAttempts = 3;
    private int attempts;

    public bool ValidateCode(int code)
    {
        attempts++;
        if (code == correctCode)
        {
            Debug.Log("Puzzle resuelto.");
            return true;
        }
        Debug.Log($"Código incorrecto. Intentos: {attempts}/{maxAttempts}");
        return false;
    }
}
