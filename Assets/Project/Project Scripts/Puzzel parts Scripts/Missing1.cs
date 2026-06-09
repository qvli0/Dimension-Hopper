using Oculus.Interaction.HandGrab;
using UnityEngine;

public class Missing1 : MonoBehaviour
{
    public Rigidbody missing1rigidbody;
    public HandGrabInteractable missing1interactable;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Spot1")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;

            missing1rigidbody.isKinematic = true;
            missing1interactable.enabled = false;
        }
    }
}
