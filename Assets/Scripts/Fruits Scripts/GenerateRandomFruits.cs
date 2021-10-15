using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateRandomFruits : MonoBehaviour
{
    public GameObject[] fruits;
    public Transform pos;
    int xpos;
    int zpos;
    int objectToGenerate;
    int objectQuantity;

    IEnumerator ObjectGenerator()
    {
        while (objectQuantity < 50)
        {
            
            objectToGenerate = Random.Range(1, 11);
            xpos = Random.Range(20, 60);
            zpos = Random.Range(20, 60);

            Instantiate(fruits[objectToGenerate - 1], new Vector3(xpos, pos.position.y, zpos), Quaternion.identity);
            
            yield return new WaitForSeconds(0.1f);
            objectQuantity += 1;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ObjectGenerator());
    }
}
