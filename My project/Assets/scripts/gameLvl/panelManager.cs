using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class panelManager : MonoBehaviour
{
    [SerializeField]
    GameObject panel, yýldýz1, yýldýz2, yýldýz3;
    [SerializeField]
    GameObject menu, tekrar, sonraki,dur,cik;


    public Text text;
    bool sonrakiBolum;
    bool Pnel;

    // Start is called before the first frame update
    void Start()
    {
        sonrakiBolum = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PanelCikar(int puan)
    {
        string bok = SceneManager.GetActiveScene().name;
        Pnel = true;
        dur.GetComponent<CanvasGroup>().DOFade(0, 0.2f);
        panel.GetComponent<CanvasGroup>().DOFade(1, 0.2f);
        if (bok == "hard")
        {
            sonraki.GetComponent<CanvasGroup>().DOFade(0, 0f);
        }
        sonrakiBolum = true;
        switch (puan)
        {
            case 6:
                yýldýz1.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.2f);
                yýldýz2.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.4f);
                yýldýz3.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.6f);
                break;
            case 5:
                yýldýz1.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.2f);
                yýldýz2.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.4f);

                break;
            case 4:
                yýldýz1.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.2f);
                yýldýz2.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.4f);
                break;
            case 3:
                yýldýz1.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.2f);

                break;
            case 2:
                yýldýz1.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.2f);

                break;
            case 1:
                yýldýz1.GetComponent<CanvasGroup>().DOFade(1, .51f).SetDelay(0.2f);
                break;
            case 0:
                break;

        }
    }

    public void Menu()
    {
        if (Pnel)
        {
            SceneManager.LoadScene("menu");
        }

    }
    public void Tekrar()
    {
        if (Pnel)
        {
            string bok = SceneManager.GetActiveScene().name;
            if (bok == "easy")
            {
                SceneManager.LoadScene("easy");
            }
            else if (bok == "normal")
            { SceneManager.LoadScene("normal"); }
            else
            {
                SceneManager.LoadScene("hard");
            }
        }

    }
    public void Sonraki()
    {
        if (sonrakiBolum)
        {
            string bok = SceneManager.GetActiveScene().name;
            if (bok == "easy")
            {
                SceneManager.LoadScene("normal");
            }
            else if (bok == "normal")
            { SceneManager.LoadScene("hard"); }
            else
            {
                Debug.Log("yeter amk");
            }
        }
    }

    public void durdur()
    {
        Pnel = true;
        dur.GetComponent<CanvasGroup>().DOFade(0, 0.1f);
        sonraki.GetComponent<CanvasGroup>().DOFade(0, 0f);
        panel.GetComponent<CanvasGroup>().DOFade(1, 0.2f);
        cik.GetComponent<CanvasGroup>().DOFade(1, 0.3f);

    }

    public void x()
    {
        panel.GetComponent<CanvasGroup>().DOFade(0, 0.2f);
        dur.GetComponent<CanvasGroup>().DOFade(1, 0.2f);
        Pnel = false;
    }

    public void olum()
    {
        Pnel = true;
        panel.GetComponent<CanvasGroup>().DOFade(1, 0.2f);
        text.GetComponent<CanvasGroup>().DOFade(1, 0.2f);
        dur.GetComponent<CanvasGroup>().DOFade(0, 0.1f);
        sonraki.GetComponent<CanvasGroup>().DOFade(0, 0f);
        
    }

}
