using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpPickup : MonoBehaviour
{

    [SerializeField] private float HpIncreaseAmount = 25f;
    [SerializeField] private AudioSource destroySFX;
    [SerializeField] private GameObject sparkParticle;
    public GameManager gameManager;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            gameManager.HpPickup(HpIncreaseAmount);
            destroySFX.Play();
            GameObject particle = Instantiate(sparkParticle, other.transform.position, Quaternion.identity);
            particle.GetComponent<ParticleSystem>().Play();
            gameObject.SetActive(false);
        }
    }

}
