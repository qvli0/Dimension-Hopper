using Oculus.Interaction.HandGrab;
using UnityEngine;

public class Missing3 : MonoBehaviour
{
    public Rigidbody missing3rigidbody;
    public HandGrabInteractable missing3interactable;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Spot3")
        {
            transform.position = new Vector3(other.transform.position.x, other.transform.position.y, other.transform.position.z);
            transform.rotation = other.transform.rotation;

            missing3rigidbody.isKinematic = true;
            missing3interactable.enabled = false;
        }
    }
}
