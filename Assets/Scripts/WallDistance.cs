using UnityEngine;

public class WallDistance : MonoBehaviour {

    
    [SerializeField]
    private GameObject wall;

    [SerializeField]
    private GameObject player;

    public static bool nearWall;

    void Start()
    {
        nearWall = false;
    }


    // Update is called once per frame
    void LateUpdate()
    {
        if ((wall.transform.position - player.transform.position).sqrMagnitude <= 13f)
        {
            Debug.Log("Burger Time!");
            nearWall = true;
            
        } else
        {
            Debug.Log((wall.transform.position - player.transform.position).sqrMagnitude);
            nearWall = false;
        }
    }
}
