using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChemistryLabPT : MonoBehaviour
{
    public Button btn;
    public GameObject PTButton;

    void Start()
    {
        btn.onClick.AddListener(PTButtonOnClick);
    }

    void PTButtonOnClick()
    {
        PTButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
