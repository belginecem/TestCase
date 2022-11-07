using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    [SerializeField] private float HpDecreaseAmount = 10f;
    public GameManager gameManager;

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            gameManager.FireDamage(HpDecreaseAmount);
        }
    }
}
