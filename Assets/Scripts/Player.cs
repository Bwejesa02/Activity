using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    float playerSpeed = 5.0f;
    float jumpHeight = 1.5f;
    float gravityValue = -9.81f;

    private Vector3 playerVelocity;
    private bool groundedPlayer;

    public InputActionReference moveAction; 
    public InputActionReference jumpAction; 

    public CharacterController CharacterController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        CharacterController.Move (playerVelocity * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (CharacterController != null)
        {

        }
    }
}
