using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MapManagment : MonoBehaviour
{

   public GameObject[] maps;
    public Button NextMap;
    public Button PreviousMap;
    int index;

    void Start() {

        index = PlayerPrefs.GetInt("mapIndex");
        for(int i = 0; i < maps.Length; i++)
        {
            maps[i].SetActive(false);
            maps[index].SetActive(true);
        }
    } 
 
    void Update()
    {
        if(index>= 2)
        {
            NextMap.interactable= false;
        }
        else
        {
            NextMap.interactable= true;
        }

        if(index <=0 )
        {
            PreviousMap.interactable= false;
        }
        else
        {
            PreviousMap.interactable= true;
        }
    }

    public void Next()
    {
        index++;
        for(int i= 0; i<maps.Length; i++)
        {
            maps[i].SetActive(false);
            maps[index].SetActive(true);
        }

        PlayerPrefs.SetInt("mapIndex",index);
        PlayerPrefs.Save();
    }

    public void Previous()
    {
        index--;
        for(int i= 0; i<maps.Length; i++)
        {
            maps[i].SetActive(false);
            maps[index].SetActive(true);
        }

        PlayerPrefs.SetInt("mapIndex",index);
        PlayerPrefs.Save();
    }

     public void ContinueGame()
   {
    SceneManager.LoadSceneAsync(2);
   }

}




