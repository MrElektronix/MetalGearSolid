using UnityEngine;

public class WallDistance : MonoBehaviour {

    
    [SerializeField]
    private GameObject _wall;

    [SerializeField]
    private GameObject _player;

    public static bool NearWall;

    private void Start()
    {
        NearWall = false;
    }


    // Update is called once per frame
    private void LateUpdate()
    {
        if ((_wall.transform.position - _player.transform.position).sqrMagnitude <= 13f)
        {
            Debug.Log("Burger Time!");
            NearWall = true;
            
        } else
        {
            Debug.Log((_wall.transform.position - _player.transform.position).sqrMagnitude);
            NearWall = false;
        }
    }
}
