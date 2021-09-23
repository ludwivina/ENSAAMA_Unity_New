using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneonClick : MonoBehaviour
{
    public int numberOfClones = 3;

    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        //Destroy(gameObject);

        //La vie :
        //Instantiate(gameObject);
        for (int i = 0; i < numberOfClones; i = i + 1) {
            GameObject clone = Instantiate (gameObject);
            Destroy(clone, 3f);

            //f
        }
    }
}

