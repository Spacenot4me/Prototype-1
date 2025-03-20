using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(-0.0599999987f, 8.88000011f, -8.92000008f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset; 
    }
}
