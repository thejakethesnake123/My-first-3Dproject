using UnityEngine;

public class CameraController : MonoBehaviour
{

    GameObject mainCamera;
    Camera camera;

    Vector2 axis;
    [SerializeField] Vector2 _sensivity = new Vector2(1, 1);

    float targetY = 0;
    float targetX = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        camera = mainCamera.GetComponent<Camera>();

        mainCamera.transform.parent = gameObject.transform;
        mainCamera.transform.localPosition = new Vector3(0, 1, 0);
        mainCamera.transform.localRotation = Quaternion.Euler(Vector3.zero);

        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        axis = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));

        ChangeY();
        ChangeX();
    }

    void ChangeY()

    {
        targetY -= axis.y * _sensivity.y;

        mainCamera.transform.localRotation = Quaternion.Euler(targetY, 0, 0);
        targetY = Mathf.Clamp(targetY, -180, 180);
    }

    void ChangeX()

    {
        targetX += axis.x * _sensivity.x;

        transform.localRotation = Quaternion.Euler(0, targetX, 0);
    }
}
