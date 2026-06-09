using UnityEngine;

public class FloatingText : MonoBehaviour
{

    public float floatSpeed = 2f;
    public float floatHeight = 0.2f;

    private Vector3 startPos;

    public Transform cameraTransform;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        float newz = startPos.z + Mathf.Sin(Time.time * floatSpeed) * floatHeight;

        transform.localPosition = new Vector3(startPos.x, startPos.y, newz);
    }

    void LateUpdate()
    {
        if (cameraTransform == null) return;

        Vector3 direction = transform.position - cameraTransform.position;

        direction.y = 0;

        transform.rotation = Quaternion.LookRotation(direction);
    }
}
