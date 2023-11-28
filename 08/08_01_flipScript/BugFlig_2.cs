using UnityEngine;
using System.Collections;

public class BugFlip : MonoBehaviour {
    private bool facingRight = true;
    private SpriteRenderer _spriteRenderer;

    void Awake() {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftArrow) && facingRight) {
            _spriteRenderer.flipX = facingRight;
            facingRight = false;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && !facingRight){
            _spriteRenderer.flipX = facingRight;
            facingRight = true; 
        }
    }
} 


