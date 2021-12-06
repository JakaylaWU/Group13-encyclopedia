using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public bool isWrong;
    public Transform buttonPanel;
    public GameObject wrongTxt;
    public GameObject successfulPanel;
    public GameObject quizPanel;
    public int count;

    private void Start()
    {
        count = 12;
        wrongTxt.SetActive(false);
        successfulPanel.SetActive(false);
        quizPanel.SetActive(true);
    }

    private void Update()
    {
        if (isWrong) 
        {
            foreach (Transform button in buttonPanel) 
            {
                button.gameObject.SetActive(true);
            }
            count = 12;
            isWrong = false;
            StartCoroutine(closeWrongTxt());
        }

        if (count <= 5)
        {
            quizPanel.SetActive(false);
            successfulPanel.SetActive(true);
        }
    }

    IEnumerator closeWrongTxt()
    {
        wrongTxt.SetActive(true);
        yield return new WaitForSeconds(1.1f);
        wrongTxt.SetActive(false);
    }

    public void SetIsWrong() 
    {
        isWrong = true;
    }

    public void QuitGame() 
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }

    public void ReduceCount() 
    {
        count--;
    }

}
