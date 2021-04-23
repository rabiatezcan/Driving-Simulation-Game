using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float carSpeed = 20.0f;
    GameObject cam;
    Vector3 camOffset = new Vector3(0, 5, -8);
    float turnDirection;
    float turnSpeed = 25f ;
    float backAndFortDirection;
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        turnDirection = Input.GetAxis("Horizontal");
        backAndFortDirection = Input.GetAxis("Vertical");
        gameObject.transform.Translate(Vector3.forward * Time.deltaTime * carSpeed * backAndFortDirection);
        gameObject.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * turnDirection);
    }
    private void LateUpdate()
    {
        CameraPositionControl();
    }
    void CameraPositionControl()
    {
        cam.transform.position = gameObject.transform.position + camOffset;
    }
}
