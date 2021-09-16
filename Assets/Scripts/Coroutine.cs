using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Execute(2));

        StartCoroutine("Execute");
        StopCoroutine("Execute");
    }

    IEnumerator Execute(float time) {
        yield return new WaitForSeconds(time);

        Debug.Log("Something is happend");
    }

}
