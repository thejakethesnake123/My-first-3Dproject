using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    CharacterController characterController;
    Vector2 axis;
    [SerializeField] float _playerSpeed;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        axis = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        characterController.Move((axis.x * transform.right + axis.y *transform.forward) * Time.deltaTime * _playerSpeed);

    }
}
