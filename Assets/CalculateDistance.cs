using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class CalculateDistance : MonoBehaviour
{
    [SerializeField] private int m_iterations;
    private readonly Vector3 m_startVector = new(10, 50, 60);
    private readonly Vector3 m_endVector = new(74, 100, 10);
    
    // Start is called before the first frame update
    void Start()
    {
        DistanceVectors();
        DistanceSqrVectors();
    }

    private void DistanceSqrVectors()
    { 
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (var i = 0; i < m_iterations; i++)
        {
            var sqrMagnitude = Vector3.SqrMagnitude(m_endVector - m_startVector);
        }
        stopWatch.Stop();
        Debug.Log("SqrMagnitude :"+stopWatch.Elapsed.Milliseconds);
    }

    private void DistanceVectors()
    {
        var stopWatch = new Stopwatch();
        stopWatch.Start();
        for (var i = 0; i < m_iterations; i++)
        {
            var magnitude = Vector3.Magnitude(m_endVector - m_startVector);
        }
        stopWatch.Stop();
        Debug.Log("Magnitude :"+stopWatch.Elapsed.Milliseconds);
    }
    
}
