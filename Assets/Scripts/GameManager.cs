using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] public float HP;
    [SerializeField] private float maxHP = 100;
    public float timer;
    public UIManager uiManager;
    public static GameManager instance;

    public void Start()
    {
        HP = 75f;
    }

    public void Update()
    {
        InGameTime();
    }



    public void FireDamage(float damage)
    {
        HP -= damage * Time.deltaTime;
        if (HP <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        uiManager.HpTextUpdate((int)HP);
    }

    public void HpPickup(float heal)
    {
        HP += heal;
        if(HP >= 100)
        {
            HP = maxHP;
        }
        uiManager.HpTextUpdate((int)HP);
    }

    public void InGameTime()
    {;
        timer += Time.deltaTime;
        uiManager.TimerText((int)timer);
    }

    public void RestartData()
    {
        HP = 75f;
        timer = 0f;
    }




}
