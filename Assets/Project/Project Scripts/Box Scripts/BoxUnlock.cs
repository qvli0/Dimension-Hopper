using Oculus.Interaction;
using Oculus.Interaction.HandGrab;
using UnityEngine;

public class BoxUnlock : MonoBehaviour
{

    public Box chest;

    public Rigidbody keyrb;
    public HandGrabInteractable keyinteractable;

    private void OnTriggerEnter(Collider other) 
    { 
        if (other.CompareTag("Key")) 
        { 
           
            chest.OpenChest();
           
            other.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            other.transform.rotation = transform.rotation;

            keyrb.isKinematic = true;
            keyinteractable.enabled = false;

        }
    }
}
