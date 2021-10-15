using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private GameObject animal;
    public AnimalSelection selectedAnimal;
    public Vector3 offset;

    private void Awake()
    {
        animal = new GameObject();
    }
    // Start is called before the first frame update
    void Start()
    {
        animal = selectedAnimal.GetAnimal();
    }

    [SerializeField]
    private Space offsetPositionSpace = Space.Self;

    [SerializeField]
    private bool lookAt = true;

    private void Update()
    {
        Refresh();
    }

    public void Refresh()
    {
        if (AnimalSelection.animals[AnimalSelection.index].transform == null)
        {
            Debug.LogWarning("Missing target reference!", this);
            return;
        }

        if (offsetPositionSpace == Space.Self)
        {
            transform.position = AnimalSelection.animals[AnimalSelection.index].transform.TransformPoint(offset);
        }
        else
        {
            transform.position = AnimalSelection.animals[AnimalSelection.index].transform.position + offset;
        }

        if (lookAt)
        {
            transform.LookAt(AnimalSelection.animals[AnimalSelection.index].transform);
        }
        else
        {
            transform.rotation = AnimalSelection.animals[AnimalSelection.index].transform.rotation;
        }
    }

}
