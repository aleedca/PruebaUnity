using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerScene : MonoBehaviour
{
    // Start is called before the first frame update
    public float transitionTime = 5f;

    public void Start()
    {
        StartCoroutine(Timer());
    }


    IEnumerator Timer()
    {
        int newIndex = (SceneManager.GetActiveScene().buildIndex + 1)%7;
        // Wait
        yield return new WaitForSeconds(transitionTime);

        // Load scene
        GetComponent<SceneLoadManager>().LoadNextScene();
    }
}
