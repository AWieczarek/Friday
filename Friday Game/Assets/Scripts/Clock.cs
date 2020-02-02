using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
    private float REAL_SECONDS_PER_INGAME_DAY = 60f;

    public Transform clockHourHandTransform;
    public Transform clockMinuteHandTransform;
    public TextMeshProUGUI clockText;

    private float day;
    void Start()
    {
        clockText = transform.Find("Clock-text").GetComponent<TextMeshProUGUI>();
        clockHourHandTransform = transform.Find("hourHand");
        clockMinuteHandTransform = transform.Find("minuteHand");
    }

    // Update is called once per frame
    void Update()
    {
        day += Time.deltaTime / REAL_SECONDS_PER_INGAME_DAY;
        float dayNormalized = day % 1f;
        float rotationDegressPerDay = 360f;
        clockHourHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegressPerDay);
        float hoursPerDay = 24f;
        clockMinuteHandTransform.eulerAngles = new Vector3(0, 0, -dayNormalized * rotationDegressPerDay*hoursPerDay);

        string hourString = Mathf.Floor(dayNormalized * hoursPerDay).ToString("00");

        float minutesPerHour = 60f;
    
        string minuteString = Mathf.Floor(((dayNormalized * hoursPerDay) % 1f) * minutesPerHour).ToString("00");
        clockText.text = hourString + ":" + minuteString;  
    }
}
