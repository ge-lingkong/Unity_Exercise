using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform hoursPivot, minutesPivot, secondsPivot;
    void Update()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, -30f * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * (float)time.TotalSeconds);
    }
}
