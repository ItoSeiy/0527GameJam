using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class GameManager : SingletonMonoBehaviour<GameManager>
{
    /// <summary>
    /// すべての鍵を取得したかどうか
    /// すべての鍵をゲットした状態でゴールに近づくとゲームクリアになる
    /// </summary>
    public bool IsGetAllKey { get; private set; } = false;

    /// <summary>ゲームスタート時に呼び出される</summary>
    public event Action OnGameStart;

    /// <summary>ゲームオーバー時に呼び出される</summary>
    public event Action OnGameOver;

    /// <summary>ゲームクリア時に呼び出される</summary>
    public event Action OnGameClear;

    [SerializeField]
    private GameObject[] _keyUis;

    [SerializeField]
    private CanvasGroup _gameClearCanvas;

    [SerializeField]
    private CanvasGroup _gameOverCanvas;

    [SerializeField]
    private float _fadeDuration = 1.0f;
        
    private int _keyUiIndex = 0;

    public void GameStart()
    {
        OnGameStart?.Invoke();
        print("ゲームスタート");
    }

    public void GameOver()
    {
        OnGameOver?.Invoke();
        _gameOverCanvas.DOFade(1f, _fadeDuration);
        print("ゲームオーバ");
    }

    public void GameClear()
    {
        OnGameClear?.Invoke();
        _gameClearCanvas.DOFade(1, _fadeDuration);
        print("ゲームクリア");
    }

    /// <summary>
    /// 鍵をゲットした時に呼び出す
    /// </summary>
    [ContextMenu("GetKey")]
    public void GetKeyItem()
    {
        if (_keyUiIndex < _keyUis.Length - 1)
        {
            _keyUis[_keyUiIndex].gameObject.SetActive(true);
            _keyUiIndex++;
            print(_keyUiIndex);
        }
        else
        {
            _keyUis[_keyUiIndex].gameObject.SetActive(true);
            IsGetAllKey = true;
            print("すべての鍵を回収した");
        }
    }
}