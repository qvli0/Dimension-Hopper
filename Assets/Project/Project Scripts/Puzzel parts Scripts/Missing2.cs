using Oculus.Interaction.HandGrab;
using UnityEngine;

public class Missing2 : MonoBehaviour
{
    public Rigidbody missing2rigidbody;
    public HandGrabInteractable missing2interactable;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Spot2")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;

            missing2rigidbody.isKinematic = true;
            missing2interactable.enabled = false;
        }
    }
}
