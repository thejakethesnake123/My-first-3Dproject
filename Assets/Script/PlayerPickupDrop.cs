using UnityEngine;

public class PlayerPickupDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickUpLayerMask;
    [SerializeField] private Transform objectGrabPointTransform;
    private void Update()
    {
            if (Input.GetKeyDown(KeyCode.E))
        {
            float pickUpDistance = 100f;
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickUpDistance, pickUpLayerMask));
                if (raycastHit.transform.TryGetComponent(out ObjectGrabbable objectGrabbable))
                {
                    objectGrabbable.Grab(objectGrabPointTransform);
                }
               
             
                

            }
        }
    }

