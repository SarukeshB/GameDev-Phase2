using System.Collections;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class RandomFirePopPS : MonoBehaviour
{
    [Header("Fire Visible Time (Seconds)")]
    public float minVisibleTime = 3f;
    public float maxVisibleTime = 7f;

    [Header("Fire Hidden Time (Seconds)")]
    public float minHiddenTime = 2f;
    public float maxHiddenTime = 5f;

    private ParticleSystem firePS;

    void Awake()
    {
        firePS = GetComponent<ParticleSystem>();

        // Make sure fire is OFF at start
        firePS.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }

    void Start()
    {
        StartCoroutine(FireRoutine());
    }

    IEnumerator FireRoutine()
    {
        while (true)
        {
            // Wait while hidden
            float hiddenTime = Random.Range(minHiddenTime, maxHiddenTime);
            yield return new WaitForSeconds(hiddenTime);

            // Play fire
            firePS.Play();

            // Stay visible
            float visibleTime = Random.Range(minVisibleTime, maxVisibleTime);
            yield return new WaitForSeconds(visibleTime);

            // Stop fire
            firePS.Stop(true, ParticleSystemStopBehavior.StopEmitting);
        }
    }
}
