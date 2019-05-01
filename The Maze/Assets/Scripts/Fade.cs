using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public Image panel1;
    public int level;
    public float fadeout = 1.0f;
    IEnumerator Start()
    {
        panel1.canvasRenderer.SetAlpha(0.0f);
        FadeIn();
        yield return new WaitForSeconds(3.0f);
        FadeOut();
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(level);

    }

    void FadeIn()
    {
        panel1.CrossFadeAlpha(1.0f, 1.5f, false);
    }

    void FadeOut()
    {
        panel1.CrossFadeAlpha(0.0f, fadeout, false);
    }
}
