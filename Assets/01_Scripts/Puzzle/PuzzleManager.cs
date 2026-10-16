using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string correctCode = "1234";
    [SerializeField] private int maxAttempts = 3;
    [SerializeField] private ChestController chest;
    private int attempts;

    public bool ValidateCode(string code)
    {
        attempts++;
        bool valid = code == correctCode;

        if (valid)
        {
            Debug.Log("Código correcto.");

            if (chest != null)
            {
                chest.Unlock();
            }
        }
        else
        {
            Debug.Log($"Código incorrecto. Intentos: {attempts}/{maxAttempts}");
        }

        return valid;
    }

    [ContextMenu("Probar código correcto")]
    private void TestCorrectCode() => ValidateCode(correctCode);
}
