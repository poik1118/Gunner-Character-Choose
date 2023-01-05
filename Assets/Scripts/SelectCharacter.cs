using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectCharacter : MonoBehaviour
{
    public Character            character;
    public SelectCharacter[]    characters;

    Animator                    animator;
    SpriteRenderer              spriteRend;

    void Start(){
        animator = GetComponent<Animator>();
        spriteRend = GetComponent<SpriteRenderer>();

        if(GameController.instance.currentCharacter == character){
            OnSelect();
        }
        else{
            OnDeselect();
        }

    }

    void OnMouseUpAsButton()
    {
        GameController.instance.currentCharacter = character;

        OnSelect();
        for (int i = 0; i < characters.Length; i++){
            if(characters[i] != this){
                characters[i].OnDeselect();
            }
        }
    }

    void OnSelect(){
        animator.SetBool("run", true);
        spriteRend.color = new Color(1f, 1f, 1f);
    }
    void OnDeselect(){
        animator.SetBool("run", false);
        spriteRend.color = new Color(0.5f, 0.5f, 0.5f);
    }
}
