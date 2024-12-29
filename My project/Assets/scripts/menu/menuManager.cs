using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using TMPro;
using UnityEditor;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    [SerializeField]
    GameObject start, exit;
    [SerializeField]
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        FadeOut();
    }
    void FadeOut()
    {
        text.GetComponent<CanvasGroup>().DOFade(1, 0.3f);
        start.GetComponent<CanvasGroup>().DOFade(1, 0.3f).SetDelay(0.1f);
        exit.GetComponent<CanvasGroup>().DOFade(1,0.3f).SetDelay(0.1f);

    }
    public void Exit()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene("lvlSelect");
    }
}
