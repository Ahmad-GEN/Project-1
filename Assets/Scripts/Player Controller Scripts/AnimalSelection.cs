using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimalSelection : MonoBehaviour
{
    public static GameObject[] animals;
    public static int index;
    private void Start()
    {
        GetAnimal();
    }

    public GameObject GetAnimal()
    {
        index = PlayerPrefs.GetInt(Constants.PlayerPrefsNames.CharacterSelected.ToString());
        animals = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++)
            animals[i] = transform.GetChild(i).gameObject;

        foreach (GameObject go in animals)
            go.SetActive(false);

        if (animals[index])
            animals[index].SetActive(true);

        return animals[index];
        
    }

    public void ToggleLeft()
    {
        animals[index].SetActive(false);
        index--;
        if (index < 0)
            index = animals.Length - 1;

        animals[index].SetActive(true);
    }
    public void ToggleRight()
    {
        animals[index].SetActive(false);
        index++;
        if (index == animals.Length)
            index = 0;

        animals[index].SetActive(true);
    }
    public void ConfirmButton()
    {
        PlayerPrefs.SetInt(Constants.PlayerPrefsNames.CharacterSelected.ToString(), index);
        ChangeScreen.ConfirmButton();
    }
}
