using System;
using System.Diagnostics;
using System.Text;
using UnityEngine;
using Debug = UnityEngine.Debug;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class TestString : MonoBehaviour
    {
        private int m_iterations=5000;
        [SerializeField] private bool m_useBuilder;
        private void Update()
        {
            if(m_useBuilder) CreateStringWithBuilder();
            else CreateStringStringConcat();
        }

        private void CreateStringStringConcat()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var myString = "";
            for (var i = 0; i < m_iterations; i++)
            {
                var rdm = Random.Range(0, 100);
                myString+=rdm;
                myString += "-";
            }
            stopWatch.Stop();
            Debug.Log("CreateStringStringConcat: "+stopWatch.Elapsed.Milliseconds);
        }

        private void CreateStringWithBuilder()
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var builder = new StringBuilder();
            for (var i = 0; i < m_iterations; i++)
            {
                var rdm = Random.Range(0, 100);
                builder.Append(rdm);
                builder.Append('-');
            }
            stopWatch.Stop();
            Debug.Log("CreateStringWithBuilder: "+stopWatch.Elapsed.Milliseconds);
        }
    }
}