using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DoorTrigett : MonoBehaviour
{
    //public Text victorytext;
    //private bool playertoucheddoor = false;
    private void OnTriggerEnter(Collider other)
    {
     if (other.CompareTag("Player"))
        {
            //playertoucheddoor = true;
            SceneManager.LoadScene("level2");
        }

    }
    //private void Update()
    //{
        //if(playertoucheddoor)
        //{
            //ShowMessage();
            //Invoke("ReloadScene", 3f);
            //playertoucheddoor = false;
       // }
    //}
    //private void ShowMessage()
    //{
        //victorytext.gameObject.SetActive(true);
    //}
    //private void ReloadScene()
    //{
       // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    //}
    //private void HideMessage()
    //{
     //   victorytext.gameObject.SetActive(false);
    //}
}
