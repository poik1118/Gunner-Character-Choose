using System.Reflection.Emit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Character{
    Black,
    Red,
    Green,
    Blue
}

public class GameController : MonoBehaviour
{
    public static GameController instance;

    private void Awake(){
        if( instance == null ){
            instance = this;
        }
        else if ( instance != null ){
            return;
        }
        DontDestroyOnLoad(gameObject);      // 씬이 전환되어도 오브젝트가 파괴되지 않음

    }

    public Character currentCharacter;
}
