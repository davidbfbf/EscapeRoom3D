using UnityEngine;

public class CodePanel : MonoBehaviour
{
    [SerializeField] private PuzzleManager puzzleManager;
    [SerializeField] private int maxDigits = 4;
    [SerializeField] private string hint = "La fecha del laboratorio"; // WIP: sistema de pistas

    private string currentInput = "";

    public void PressDigit(int digit)
    {
        if (currentInput.Length >= maxDigits)
        {
            return;
        }

        currentInput += digit.ToString();
        Debug.Log($"Código ingresado: {currentInput}");
    }

    public void Submit()
    {
        if (puzzleManager == null)
        {
            Debug.LogWarning("CodePanel no tiene un PuzzleManager asignado.");
            return;
        }

        puzzleManager.ValidateCode(currentInput);
        currentInput = "";
    }

    public void Clear()
    {
        currentInput = "";
        // TODO: reproducir sonido de borrado (pendiente de assets de audio)
        Debug.Log("Panel limpiado.");
    }
}
