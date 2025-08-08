using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using UnityEngine.TextCore.Text;

public class ChemistryLabPT : MonoBehaviour
{
    public UnityEngine.UI.Button btn;
    public GameObject PTButton;
    public GameObject Beaker;
    public GameObject Bottle;
    public TextMeshProUGUI robotInstructions;
    public TextMeshProUGUI PTInstructions;
    // public TextMeshProUGUI robotInformationColor;

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

        StartCoroutine(StartTime());
    }

    IEnumerator StartTime()
    {
        yield return new WaitForSeconds(10.0f);
        Beaker.SetActive(false);
        Bottle.SetActive(false);
        PTInstructions.text = "Practice completed, you will now complete a callibration process before conducting the study.";
        robotInstructions.text = "Well done for completing this practice trial.";
        // robotInformationColor.color =Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
