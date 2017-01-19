using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private const float Speed = 4f;

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
    }
}
	
	
	
