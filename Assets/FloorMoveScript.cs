using UnityEngine;
using System.Collections;

public class FloorMoveScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
		Resolution[] resolutions = Screen.resolutions;
		Screen.SetResolution(resolutions[0].width, resolutions[0].height, true);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.x < -3.9f)
        {
            transform.localPosition = new Vector3(0, transform.localPosition.y, transform.localPosition.z);
        }
        transform.Translate(-Time.deltaTime, 0, 0);
    }


}
