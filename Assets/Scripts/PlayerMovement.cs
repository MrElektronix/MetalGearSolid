using UnityEngine;

[RequireComponent((typeof(Rigidbody)))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float Speed = 2f;

    [SerializeField]
    private Rigidbody _rigidbody;


    // Use this for initialization
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        var x = Input.GetAxisRaw("Horizontal") * Speed;
        var z = Input.GetAxisRaw("Vertical") * Speed;
        _rigidbody.velocity = new Vector3(x, 0f, z);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            Speed = 2.5f;
        }
        else
        {
            Speed = 1.5f;
        }
    }
}
	
	
	
