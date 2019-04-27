using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public GameObject RetryOpen;

    public void callRetry()
    {
        RetryOpen.SetActive(true);
    }


    // Start is called before the first frame update
    void Start()
    {
       // RetryOpen.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {

    }

    public void RetryGame()
    {
        SceneManager.LoadScene("Peach blossom source");
    }

}
