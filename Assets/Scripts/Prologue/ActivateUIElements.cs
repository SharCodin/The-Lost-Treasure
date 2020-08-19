using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ActivateUIElements : MonoBehaviour
{

    [SerializeField] GameObject FadeInImage = null;


    // Start is called before the first frame update
    void Start()
    {
        FadeInImage.SetActive(true);
        Destroy(FadeInImage);
    }

}
