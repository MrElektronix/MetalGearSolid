using UnityEngine;

[RequireComponent((typeof(AudioSource)))]
[RequireComponent((typeof(Rigidbody)))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 4f;

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

        var x = Input.GetAxisRaw("Horizontal") * _speed;
        var z = Input.GetAxisRaw("Vertical") * _speed;
        _rigidbody.velocity = new Vector3(x, 0f, z);

        _speed = Input.GetKey(KeyCode.LeftShift) ? 2.5f : 1.5f;
    }
}
	
	
	
