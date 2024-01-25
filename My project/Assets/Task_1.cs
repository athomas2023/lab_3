using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task_1 : MonoBehaviour
{

    public string courseName = "DIG 4714" ;
    public float modulesFactor = 15f;
    public float readingFactor = 30f;
    public float quizzesFactor = 15f;
    public float assignmentFactor = 30f;
    public float professorFactor = 10f;
    public bool professorHasTaught = false;
    private float total;
    private string totalPercentages;

    public bool submitUpdates = false;
    // Start is called before the first frame update
    void Start()
    {
        total = modulesFactor + readingFactor + quizzesFactor + assignmentFactor + professorFactor;
        totalPercentages = total.ToString();
        Debug.Log("Welcome to " + courseName);
        Debug.Log("The Currect course total percentage is " + total);
    }

    // Update is called once per frame
    void Update()
    {
        Toggle();
    }

    public void Toggle()
    {
        if (submitUpdates == true)
        {
            total = modulesFactor + readingFactor + quizzesFactor + assignmentFactor + professorFactor;
            totalPercentages = total.ToString();
            Debug.Log("Welcome to " + courseName);
            Debug.Log("The Currect course total percentage is " + total);
            submitUpdates= false;
        }
    }




}
