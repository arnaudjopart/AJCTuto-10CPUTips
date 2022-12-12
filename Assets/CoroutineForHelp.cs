using System.Collections;
using UnityEngine;

public class CoroutineForHelp : MonoBehaviour
{
    private WaitForSeconds m_waitForSeconds = new WaitForSeconds(1);
    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (true)
        {
            DoSomethingHeavy();
            yield return m_waitForSeconds;
        }
    }


    private void DoSomethingHeavy()
    {
        //Doing stuff
    }
}
