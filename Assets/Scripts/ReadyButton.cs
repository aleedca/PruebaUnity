using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReadyButton : MonoBehaviour
{
    public Animator readyAnimation;

    public void Ready()
    {
        readyAnimation.SetTrigger("Ready");
        SceneManager.LoadScene(3);
    }
}
