using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour {

    private Vector3 offset;
    public GameObject player;
    void Start()
    {
        offset = transform.position - player.transform.position;

    }

    // For the jump offset, just save offset before jump, let the camera follow the character, then set the offset back to original offset
    void Update()
    {
      

    }

    void LateUpdate()

    {

        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X"), Vector3.up) * offset;
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);
        
    }
}
