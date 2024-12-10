using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlaySteps : MonoBehaviour
{
    PlayableDirector director;
    public List<Step> steps;
    
    void Start()
    {
        director = GetComponent<PlayableDirector>();
    }
    [System.Serializable]
    public class Step
    {
        public string name; 
        public float time;
        public bool hasplayed = false;
    }

    public void PlayStepIndex(int index)
    {
        Step step = steps[index];

        if (!step.hasplayed)
        {
            director.Stop();
            director.time = step.time;
            director.Play();
        }
    }

    void Update()
    {
        
    }
}
