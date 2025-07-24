using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameOver : MonoBehaviour
{

    public Characters Characters;
    public TipsItems Tips;
    public VideoClip Clip;
    public GameOvverBtn GameOvverBtn;
    public CG videoCG;
    public PlayerMoveController PlayerMoveController;
    public GameOverText GameOverText;
    private void Start()
    {

    }

    public void playGameOverCG()
    {
        videoCG.playVideo(Clip);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            videoCG.stopVideo();
            GameOverText.show();
        }

    }

    void Update()
    {
        if (Tips.photo && Tips.knife && Tips.pillien)
        {
            if (Characters.Character1 && Characters.Character2 && Characters.Character3)
            {
                GameOvverBtn.show();
                PlayerMoveController.UIstate=true;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
           
        
    }
}
