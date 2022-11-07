using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI Health;
    [SerializeField] private TextMeshProUGUI Time;
    GameManager gameManager;

    private void Start()
    {
        GetTime();
        GetData(Health.ToString());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //gameManager.RestartData();
            SceneManager.LoadScene(0);
        }
    }

    private void GetData(string hp)
    {
        //Health.text = "HP: " + hp;
    }

    private void GetTime()
    {
        //Time.text = gameManager.timer.ToString();
    }
}
