using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI HealthPoint;
    [SerializeField] private TextMeshProUGUI Time;

    public void HpTextUpdate(int hp)
    {
       HealthPoint.text = "HP: " + hp;
    }

    public void TimerText(int timer)
    {
        //Time.text = timer.ToString();
    }
}
