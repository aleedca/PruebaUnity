using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadManager : MonoBehaviour
{

    [SerializeField] public float transitionTime;
    public int nextSceneIndex;

    private Animator transitionAnimator;
    // Update is called once per frame
    void Start()
    {
        transitionAnimator = GetComponentInChildren<Animator>();
    }

    public void LoadNextScene()
    {
        //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1; 
        StartCoroutine(SceneLoad(nextSceneIndex));
    }

    public IEnumerator SceneLoad(int sceneIndex)
    {
        transitionAnimator.SetTrigger("StartTransition");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneIndex);
    }
}
