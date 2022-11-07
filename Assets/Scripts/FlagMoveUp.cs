using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagMoveUp : MonoBehaviour
{
    private GameObject ball;
    private GameObject flag;
    private float ballEnterFlagZone;
    [SerializeField] private Material FlagMat;
    [SerializeField] private GameObject moveableWall;


    void Start()
    {

        ball = GameObject.FindGameObjectWithTag("Ball");
        flag = GameObject.FindGameObjectWithTag("Flag");
    }

    void FixedUpdate()
    {
        NearFlag();
    }

    private void OnTriggerEnter(Collider other)
    {
        ballEnterFlagZone = ball.transform.position.z;
    }

    void NearFlag()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        float flagY = Mathf.InverseLerp(ballEnterFlagZone, flag.transform.position.z, ball.transform.position.z) * 3.5f;
        flag.transform.position = new Vector3(transform.position.x, flagY + 2f, transform.position.z);

        if (flag.transform.position.y > 4.4f)
        {
            flag.GetComponent<MeshRenderer>().material = FlagMat;
            LeanTween.moveZ(moveableWall,28.04f,2f);
            Destroy(this);
        }
    }
}
