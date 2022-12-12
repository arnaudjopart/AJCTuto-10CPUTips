using System;
using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;

public class TransformBenchmark : MonoBehaviour
{
    private Transform m_myTransform;
    private Vector3[] m_positions;
    private const int Iterations = 5000000;

    private void Create()
    {
        m_positions = new Vector3[Iterations];
        for (int i = 0; i < Iterations; i++) {
            m_positions[i] = Random.insideUnitSphere * Random.Range(0, 100);
        }
    }
    
    private void Start()
    {
        m_myTransform = GetComponent<Transform>();
        Create();
        TestTransform(); 
        TestMyTransform(); 
        TestGetComponentTransform();
    }
    
    private void TestGetComponentTransform()
    {
        var stopWatch = new Stopwatch();
        
        stopWatch.Start();
        for (var i = 0; i < Iterations; i++) GetComponent<Transform>().position = m_positions[i];
        stopWatch.Stop();
        
        UnityEngine.Debug.Log("Test GetComponent<Transform>: "+stopWatch.Elapsed.Milliseconds+" ms");
    }
    
    
    
    private void TestTransform()
    {
        var stopWatch = new Stopwatch();
        
        stopWatch.Start();
        for (var i = 0; i < Iterations; i++) transform.position = m_positions[i];
        stopWatch.Stop();
        
        UnityEngine.Debug.Log("Test .transform: "+stopWatch.Elapsed.Milliseconds+" ms");
    }

    private void TestMyTransform()
    {
        var stopWatch = new Stopwatch();
        
        stopWatch.Start();
        for (var i = 0; i < Iterations; i++) m_myTransform.position = m_positions[i];
        stopWatch.Stop();
        
        UnityEngine.Debug.Log("Test cached Transform: "+stopWatch.Elapsed.Milliseconds+" ms");
    }

    
}