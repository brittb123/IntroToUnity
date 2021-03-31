using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnBehavior : MonoBehaviour
{
    // Lowest Y able to be used
    public float Ymin;

    // Max Y able to be use
    public float Ymax;

    // Timer between spawns of pipes
    public float TimeInterval;

    // A boool to tell when the game is over
    public bool GameOver = false;

    // A Reference to the game object of the pipe pairs
    public GameObject PipeRef;
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(SpawnPipes());
    }

    public IEnumerator SpawnPipes()
    {
        float RandY = 0;


        while(!GameOver)
        {
            RandY = Random.Range(Ymin, Ymax);

            Vector3 Spawn = new Vector3(transform.position.x, RandY, transform.position.z);

            GameObject pipe = Instantiate(PipeRef.gameObject, Spawn, new Quaternion());

            MovementBehavior MoveScript = pipe.GetComponent<MovementBehavior>();

            MoveScript.StartCos = Random.Range(-1, 1);

            // Spawns the pipe reference at a positon and basic rotation;
            Instantiate(PipeRef, Spawn, new Quaternion());

            // A return that waits before continuing the funrction
            yield return new WaitForSeconds(TimeInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
