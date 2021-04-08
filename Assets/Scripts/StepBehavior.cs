using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StepBehavior : MonoBehaviour
{
    #region Variables
    [TextArea(15,50)]
    public string contentText;
    public string locationName ;
    public Sprite locationImage;

    public StepBehavior[] nextSteps;

    public Text currentLocation;

    #endregion

    #region Unity lifecycle
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    #endregion

}
