using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UseData : MonoBehaviour
{/**
  * Tutorial link
  * https://github.com/tikonen/blog/tree/master/csvreader
  * */

    List<Dictionary<string, object>> data;
    //public GameObject myCube;//prefab

    int rowCount; //variable 

    private float startDelay = 2.0f;
    private float timeInterval = 1.0f;
    public object tempObj;
    public float tempFloat;

    void Awake()
    {

        data = CSVReader.Read("udata");//udata is the name of the csv file 

        for (var i = 0; i < data.Count; i++)
        {
            //name, age, speed, description, is the headers of the database
            print("xco2 " + data[i]["xco2"] + " ");

        }


    }//end Awake()

    // Use this for initialization
    void Start()
    {
        for (var i = 0; i < data.Count; i++)
        {
            object xco2 = data[i]["xco2"];//get age data
            gameObject.transform.localScale = new Vector3((float)xco2, (float)xco2, (float)xco2);
            //cubeCount += (int)xco2;//convert age data to int and add to cubeCount
            //Debug.Log("cubeCount" +cubeCount);
        }

        InvokeRepeating("SpawnObject", startDelay, timeInterval);


    }//end Start()




    void SpawnObject()
    {
        tempObj = (data[rowCount]["xoc2"]);
        tempFloat = System.Convert.ToSingle(tempObj);
        tempFloat = (tempFloat - 350.0f) * 5.0f;


        rowCount++;

        transform.localScale = new Vector3(tempFloat, tempFloat, tempFloat);

        Debug.Log("The tempFloat is" + tempFloat);
        Debug.Log("Count" + rowCount);
    }


























    // Update is called once per frame
    void Update()
    {
        
    }
}

   
    







