using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    private new Transform transform;


    private void Awake()
    {
        transform = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start()
    {
        //NOPE  
    }

    // Update is called once per frame
    void Update()
    {
 
        Quaternion currentRotation = transform.rotation;
        Quaternion deltaRotationX = Quaternion.Euler(10 * Time.deltaTime, 0, 0);
        Quaternion deltaRotationY = Quaternion.Euler(0, 20 * Time.deltaTime, 0);
        Quaternion deltaRotationZ = Quaternion.Euler(0, 0, 25 * Time.deltaTime);
        currentRotation *= deltaRotationX;
        currentRotation *= deltaRotationY;
        currentRotation *= deltaRotationZ;

        // Setze die neue Rotation
        transform.rotation = currentRotation;
    }
}
