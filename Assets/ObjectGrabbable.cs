using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;

    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }
    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
    }

    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null)
        {
            objectRigidbody.MovePosition(objectGrabPointTransform.position);
        }

    }      
}
