using UnityEngine;
using System.Collections;

public class WaterBlock : MonoBehaviour {
    const string TAG_PLAYER = "Player";
    const string ANIMATION_TRIGGER_FALL = "Fall";

    private Animator animatorController;

    void Start(){
        animatorController = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D hit){
        if(hit.CompareTag(TAG_PLAYER)){
            animatorController.SetTrigger(ANIMATION_TRIGGER_FALL);
        }
    }
}