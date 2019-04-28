using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDownCount : MonoBehaviour
{
    public static TimerDownCount instance;
    public int time = 300;
    [SerializeField]
    private Text text;

    private void Start()
    {
        instance = this;
        OnValidate();
    }

    public void StartTimer()
    {
        StartCoroutine(TimerDown());
    }

    private IEnumerator TimerDown()
    {
        while (time > 0)
        {
            time--;
            text.text = (time / 60).ToString() + ":" + (time % 60).ToString();
            yield return new WaitForSeconds(1);
        }
    }

    private void OnValidate()
    {
        text = gameObject.GetComponentInChildren<Text>();
        Debug.Assert(text != null);
    }
}
