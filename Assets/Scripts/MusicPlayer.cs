using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        int numMusicPlayers = FindObjectsOfType<MusicPlayer>().Length; //3add el objects ele feha Script MusicPlayer f Scenes kolha Because of Objectssssss
            if (numMusicPlayers > 1)
        {
            Destroy(gameObject); //bydestroy ele gy gded lakn el intial hwa sha8al already kda kda 
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
   
}
