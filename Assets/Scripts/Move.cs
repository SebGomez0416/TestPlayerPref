using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movement;
    [SerializeField] private float speed;
    static public string position = "position";
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 pos = rb.position;
        pos.z = PlayerPrefs.GetFloat(position,0f);
        rb.position = pos;
    }

    private void Update()
    {
        movement.z = Input.GetAxisRaw("Vertical");
        movement.x = Input.GetAxisRaw("Horizontal");
    }
    
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement*(speed*Time.deltaTime));
    }

}
