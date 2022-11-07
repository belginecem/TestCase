using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameTime : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(time());
    }
    IEnumerator time()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
        }
    }

}
