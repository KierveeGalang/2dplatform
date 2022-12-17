using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class enemy_reac : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    } 
    void OnTriggerEnter2D (Collider2D other){
// Checking if the overlapped collider is an enemy
if (other.CompareTag ("enemy")) {
// This scene HAS TO BE IN THE BUILD SETTINGS!!!
SceneManager.LoadScene ("SampleScene");
}
}

}
