using UnityEngine;
using UnityEngine.Rendering.Universal;

public class Day : MonoBehaviour
{
    public AnimationCurve cycle;
    public Gradient colors;


    public float dayLength = 100f;
    Light2D sun;

    float current = 0f;

    void Start()
    {
        sun = GetComponent<Light2D>();
    }

    void Update()
    {
        current = (current + Time.deltaTime) % dayLength;
        float t = current / dayLength;

        sun.intensity = cycle.Evaluate(t);
        sun.color = colors.Evaluate(t);
    }
}
