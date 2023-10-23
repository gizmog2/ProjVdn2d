using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
    [SerializeField] string PlayerTag;
    [SerializeField] string NextSceneName;
    [SerializeField] Image ScreenBlackout;

    private bool finished;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (finished)
        {
            return;
        }
        
        if(!collision.gameObject.CompareTag(PlayerTag))
        {
            return;
        }
        finished = true;
        //SceneManager.LoadScene(NextSceneName);
    }

    private void Update()
    {
        UpdateBackgroundScreen();
    }

    private void UpdateBackgroundScreen()
    {
        if (!finished) { return; }
        if (ScreenBlackout.color.a >= 1f)
        {
            SceneManager.LoadScene(NextSceneName);
            enabled = false;
        }

        var color = ScreenBlackout.color;
        color.a += 0.01f;
        ScreenBlackout.color = color;
    }


}
