using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelSelectManager : MonoBehaviour
{
    [SerializeField]
    GameObject hard, normal, easy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HardMode()
    {
        SceneManager.LoadScene("hard");
    }
    public void NormalMode()
    {
        SceneManager.LoadScene("normal");
    }
    public void EasyMode()
    {
        SceneManager.LoadScene("easy");
    }
}
