using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodsMap : MonoBehaviour
{
    // declares a map of ints to points
    public Dictionary<string, Food> foodDictionary;

    // Start is called before the first frame update
    void Start()
    {
        foodDictionary = new Dictionary<string, Food>();
    }

    // Update is called once per frame
    //void Update()
    //{

    //}
}
