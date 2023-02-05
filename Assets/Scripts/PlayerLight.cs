using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{
    public float increaseNumber;
    private static PlayerLight _instance;

    Light lt;

    public static PlayerLight Instance
    {
        get{
            if(_instance == null){
                Debug.Log("Player is null");
            }
            return _instance;
        }
    }

    void Awake(){
        _instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        lt = GetComponent<Light>();
        lt.type = LightType.Spot;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addSpotAngle(float number){
        lt.spotAngle = lt.spotAngle + number;
    }
}
