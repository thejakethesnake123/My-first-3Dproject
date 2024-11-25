using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform objectGrabPointTransform;

  
    //bool _destroytrash = false;
    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>();
    }
    public void Grab(Transform objectGrabPointTransform)
    {
        this.objectGrabPointTransform = objectGrabPointTransform;
        objectRigidbody.useGravity = false;
        objectRigidbody.isKinematic = true;
    }

    void Start()
    {

    }

    //void update()
    //{
    //    if (_destroytrash == true)
    //    {
    //        Destroy(gameObject);
    //    }
    //}

    public void Drop()
    {
        this.objectGrabPointTransform = null;
        objectRigidbody.useGravity = true;
        objectRigidbody.isKinematic = false;
    }
    private void FixedUpdate()
    {
        if (objectGrabPointTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, objectGrabPointTransform.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "trashcan")
        {

            {
                Debug.Log("enter");
                GlobalScore.SCORE += 1;
                Instantiate(gameObject, new Vector3(0, 0, 0), Quaternion.identity);
                Destroy(gameObject);
            }
        }

        void OnCollisionExit(Collision collision)
        {
            if (collision.gameObject.tag == "trashcan")
            {
                Debug.Log("Exit");
            }
        }



    }
}
