using UnityEngine;

public class SwitchCamera : MonoBehaviour
{

    public GameObject player;
    private Vector3 offset = new Vector3(0, 5.07000017f, 11.2600002f);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
