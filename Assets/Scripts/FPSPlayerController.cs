using UnityEngine;

public class FPSPlayerController : MonoBehaviour
{
    [Range(0f, 50f)]
    [SerializeField] private float movementSpeed;
    [SerializeField] private float rotSpeedH = 1f;
    [SerializeField] private float rotSpeedV = 1f;
    
    private float xRotation = 0.0f;
    private float yRotation = 0.0f;

    public CharacterController characterController;
    private Rigidbody rb;

    void Start()
    {
        gameObject.transform.position = Vector3.zero;
        rb = GetComponent<Rigidbody>();
        // characterController = GetComponent<CharacterController>();
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        // rb.velocity = new Vector3(h, rb.velocity.y, v) * movementSpeed;
        
        
        characterController.Move((Camera.main.transform.right * h * movementSpeed + Camera.main.transform.forward * v * movementSpeed) * Time.deltaTime);
        
        float mouseX = Input.GetAxis("Mouse X") * rotSpeedH;
        float mouseY = Input.GetAxis("Mouse Y") * rotSpeedV;
 
        yRotation += mouseX;
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90);
        Camera.main.transform.eulerAngles = new Vector3(xRotation, yRotation, 0.0f);

    }
}
