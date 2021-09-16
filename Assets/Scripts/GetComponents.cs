using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponents : MonoBehaviour
{
    
    Transform myTransform;

    void Start()
    {
        myTransform = transform;

        myTransform.position = new Vector3(10, 20, 30);
    }

}
