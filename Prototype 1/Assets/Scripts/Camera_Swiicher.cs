using UnityEngine;
using UnityEngine.Rendering;

public class Camera_Swiicher : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject SwitchCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            MainCamera.SetActive(true);
            SwitchCamera.SetActive(false);
        }
        if (Input.GetKeyDown("2"))
        {
            MainCamera.SetActive(false);
            SwitchCamera.SetActive(true);
        }
    }
}
