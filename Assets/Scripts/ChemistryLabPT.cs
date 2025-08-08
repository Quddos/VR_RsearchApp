using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChemistryLabPT : MonoBehaviour
{
    public Button btn;
    public GameObject PTButton;
    public GameObject Beaker;
    public GameObject Bottle;
    public TextMeshProUGUI robotInstructions;

    void Start()
    {
        // by default the bottle will not appear
        Beaker.SetActive(false);
        Bottle.SetActive(false);
        btn.onClick.AddListener(PTButtonOnClick);
    }

    void PTButtonOnClick()
    {
        // upon clicking the PracticalTrial Button the bottle and beaker will show to the user
        PTButton.SetActive(false);
        Beaker.SetActive(true);
        Bottle.SetActive(true);
        robotInstructions.text = "Grab the bottle and pour the liquid in it inot the Beaker";
        robotInstructions.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
