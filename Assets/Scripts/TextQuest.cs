using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables
    public Text contentLabel;
    public Text locationLabel;
    public StepBehavior startStep;

    private StepBehavior currentStep;

    #endregion

    #region Unity lifecycle
    void Start()
    {
        currentStep = startStep;
        UpdateCurrentLabel();
        UpdateCurrentLocation(startStep.locationName);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            MoveToNextStep(0);
            UpdateCurrentLocation(currentStep.locationName);
            //currentStep.currentLocation.text
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MoveToNextStep(1);
            UpdateCurrentLocation(currentStep.locationName);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            MoveToNextStep(2);
            UpdateCurrentLocation(currentStep.locationName);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            MoveToNextStep(3);
            UpdateCurrentLocation(currentStep.locationName);
        }

    }

    #endregion

    #region Private methods
    private void UpdateCurrentLabel()
    {
        contentLabel.text = currentStep.contentText;
    }
    private void UpdateCurrentLocation(string currentLocation)
    {
        locationLabel.text = currentLocation;
    }
    private void MoveToNextStep(int stepIndex)
    {
        if (currentStep.nextSteps.Length > stepIndex)
        {
            currentStep = currentStep.nextSteps[stepIndex];
            UpdateCurrentLabel();
        }
    }
    #endregion
}
