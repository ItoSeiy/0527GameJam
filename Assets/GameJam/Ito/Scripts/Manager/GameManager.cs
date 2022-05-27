using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    /// <summary>ゲームスタート時に呼び出される</summary>
    public event Action OnGameStart;

    /// <summary>ゲームオーバー時に呼び出される</summary>
    public event Action OnGameOver;

    /// <summary>ゲームクリア時に呼び出される</summary>
    public event Action OnGameClear;

    public void GameStart()
    {
        OnGameStart?.Invoke();
    }

    public void GameOver()
    {
        OnGameOver?.Invoke();
    }

    public void GameClear()
    {
        OnGameClear?.Invoke();
    }
}