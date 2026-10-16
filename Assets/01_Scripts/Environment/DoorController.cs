using UnityEngine;

public class DoorController : MonoBehaviour, IInteractable
{
    [SerializeField] private Animator animator;

    public void Interact()
    {
        if (animator != null)
        {
            animator.SetTrigger("Open");
        }

        Debug.Log("Puerta abierta. ¡Escape completado!");
    }
}
