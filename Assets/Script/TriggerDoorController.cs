using UnityEngine;

public class DoorControl : MonoBehaviour
{

    [SerializeField] private Animator myDoor = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collide");
       if (other.CompareTag("Player"))
        {
            Debug.Log("Open");
            if (openTrigger)
            {
                myDoor.Play("DoorOpen", 0, 0.0f);
                gameObject.SetActive(false);
            }

            else if (closeTrigger)
            {
                myDoor.Play("DoorClose", 0, 0.0f);
                gameObject.SetActive(false);
            }
        }
    }

}
