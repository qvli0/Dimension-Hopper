using Oculus.Interaction.HandGrab;
using UnityEngine;

public class SecretDoorOpen : MonoBehaviour
{
    public HandGrabInteractable[] handGrabInteractables;
    public Animator dooranimator;

    public void Update()
    {
        for (int i = 0; i < handGrabInteractables.Length; i++)
        {
            if (handGrabInteractables[i].enabled)
            {
                return;
            }
        }

        dooranimator.SetTrigger("OpenDoor");
        enabled = false;
    }

}
