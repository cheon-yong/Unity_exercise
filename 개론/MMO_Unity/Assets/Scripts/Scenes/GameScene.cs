using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScene : BaseScene
{
    void VeryComlicated()
    {
        for (int i = 0; i < 10000000; i++)
        {
            // ���� �۾�
            Debug.Log("Hello");
        }
    }

    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Game;

        Managers.UI.ShowSceneUI<UI_Inven>();
    }

    private void Update()
    {
        VeryComlicated();
    }

    public override void Clear()
    {
        
    }
}
