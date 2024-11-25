using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    public GameObject Trash;
    public Score score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {

    }    
    void OnCollisionEnter(Collision collision)
    {
    // Check if the collided object has a specific tag
        if (collision.gameObject.CompareTag("trashcan"))
        { 
            Debug.Log("Score");
            score.AddScore();
        }
    }
    
   
}

