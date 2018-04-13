using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
 public class time : MonoBehaviour
{
    public UnityEvent gameover;
    public GameObject text;
    public int TotalTime = 60;
    public UnityEvent contrlpad;
    void Start()
    {

        StartCoroutine(CountDown());

    }
    
    IEnumerator CountDown()
    {
        

        while (TotalTime >= 0)
        {
            text.GetComponent<Text>().text = TotalTime.ToString();
            yield return new WaitForSeconds(1);
            TotalTime--;
            if (TotalTime <= 2390)
            {
                contrlpad.Invoke();

            }
        }
        
        if(TotalTime < 0)
        {
            gameover.Invoke();
            yield return new WaitForSeconds(3);
            loadscene();
            
        }
       
    }
   void loadscene()
    {
        Application.LoadLevel(0);
    }
}