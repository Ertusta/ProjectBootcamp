using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarSelection : MonoBehaviour
{
    public GameObject[] cars;
    public Button NextCar;
    public Button PreviousCar;
    int index;

    void Start() {

        index = PlayerPrefs.GetInt("carIndex");
        for(int i = 0; i < cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }
    } 
 
    void Update()
    {
        if(index>= 2)
        {
            NextCar.interactable= false;
        }
        else
        {
            NextCar.interactable= true;
        }

        if(index <=0 )
        {
            PreviousCar.interactable= false;
        }
        else
        {
            PreviousCar.interactable= true;
        }
    }

    public void Next()
    {
        index++;
        for(int i= 0; i<cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }

        PlayerPrefs.SetInt("carIndex",index);
        PlayerPrefs.Save();
    }

    public void Previous()
    {
        index--;
        for(int i= 0; i<cars.Length; i++)
        {
            cars[i].SetActive(false);
            cars[index].SetActive(true);
        }

        PlayerPrefs.SetInt("carIndex",index);
        PlayerPrefs.Save();
    }

    public void Race()
    {
        GameObject muscle = GameObject.FindWithTag("MuscleCar");
        GameObject formula = GameObject.FindWithTag("FormulaCar");
        if (muscle != null && muscle.activeInHierarchy)
        {
            SceneManager.LoadSceneAsync(4);
        }
        else if (formula != null && formula.activeInHierarchy)
        {
            SceneManager.LoadSceneAsync(5);
        }
    }
}





