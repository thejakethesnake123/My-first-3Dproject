using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickupDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    [SerializeField] private float pickUpDistance;


    private ObjectGrabbable objectGrabbable;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrabbable == null)
            {
                //not carrying an object, try to grab
                float pickUpDistance = 50f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpLayerMask))
                {
                    if (raycastHit.transform.TryGetComponent(out objectGrabbable))
                    {
                        Debug.Log("Grab");
                        objectGrabbable.Grab(objectGrabPointTransform);
                    }

                }


            }
        else
        {

            objectGrabbable.Drop();
            objectGrabbable = null;

        }
        }
    }
}