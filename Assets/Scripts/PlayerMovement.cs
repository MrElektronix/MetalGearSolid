using UnityEngine;

[RequireComponent((typeof(Rigidbody)))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float Speed = 2f;

    [SerializeField]
    private Rigidbody _rigidbody;

    [SerializeField]
    private AudioSource _audio0;
    [SerializeField]
    private AudioClip _walking;
    private bool _audioPlaying;

    // Use this for initialization
    private void Start()
    {
         _audioPlaying = _audio0.isPlaying;
        _rigidbody = GetComponent<Rigidbody>();
    }


    private void Update()
    {
        _audioPlaying = _audio0.isPlaying;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (_audioPlaying == false)
            {
                _audio0.PlayOneShot(_walking, 0.1F);
                Debug.Log("isPlaying");
            }
        }

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
	
	
	
