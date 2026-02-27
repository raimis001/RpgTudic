using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Day : MonoBehaviour
{
    [SerializeField]
    Gradient gradient;
    [SerializeField]
    AnimationCurve curve;


    public static int hour = 0;

    public int startHour = 6;
    public float dayTime = 100f;

    public float currentTime = 0f;

    Light2D sun;

    void Start()
    {
        sun = GetComponent<Light2D>();
        currentTime = startHour / 24f * dayTime;
        hour = startHour;
        float timePercent = currentTime / dayTime;
        SetSun(timePercent);
    }

    void Update()
    {
        currentTime = (currentTime + Time.deltaTime) % dayTime;

        //currentTime += Time.deltaTime;
        //if (currentTime > dayTime)
        //{
        //    currentTime = 0f;
        //}

        float timePercent = currentTime / dayTime;
        hour = Mathf.FloorToInt(timePercent * 24f) ;

        SetSun(timePercent);
    }

    void SetSun(float timePercent)
    {
        sun.intensity = curve.Evaluate(timePercent);
        sun.color = gradient.Evaluate(timePercent);
    }

}
