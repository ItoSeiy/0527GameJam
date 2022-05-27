using DG.Tweening;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// サウンドを管理するスクリプト
/// </summary>
public class SoundManager : SingletonMonoBehaviour<SoundManager>
{
    public AudioSource BGMAudioSource => _bgmAudioSource;
    public AudioSource SFXAudioSouece => _sfxAudioSource;

    [SerializeField]
    SoundPoolParams _soundObjParam = default;

    [SerializeField]
    [Header("BGMを流すAudioSource")]
    AudioSource _bgmAudioSource;

    [SerializeField]
    [Header("効果音を流すAudioSource")]
    AudioSource _sfxAudioSource;

    List<Pool> _pool = new List<Pool>();

    int _poolCountIndex = 0;

    protected override void Awake()
    {
        base.Awake();
        CreatePool();
        //デバッグ用
        //_pool.ForEach(x => Debug.Log($"オブジェクト名:{x.Object.name}種類: {x.Type}"));
    }

    public void PlayeBGM(AudioClip bgmClip)
    {
        _bgmAudioSource.PlayOneShot(bgmClip);
    }

    public void PlayeBGM(AudioClip bgmClip, float volumeScale)
    {
        _bgmAudioSource.clip = bgmClip;
        _bgmAudioSource.volume = volumeScale;
        _bgmAudioSource.Play();
    }

    /// <summary>
    /// 指定したオーディオソースのフェードを行う
    /// </summary>
    /// <param name="targetAudioSouece">フェードしたいオーディオソース</param>
    /// <param name="targetVol">設定したい音量</param>
    /// <param name="fadeTime">どのくらい時間をかけるか</param>
    public void FadeAudioSource(AudioSource targetAudioSouece, float targetVol, float fadeTime)
    {
        targetAudioSouece.DOFade(targetVol, fadeTime);
    }

    /// <summary>
    /// 設定したオブジェクトの種類,数だけプールにオブジェクトを生成して追加する
    /// 再帰呼び出しを用いている
    /// </summary>
    private void CreatePool()
    {
        if (_poolCountIndex >= _soundObjParam.Params.Count)
        {
            //デバッグ用
            //Debug.Log("すべてのオーディオを生成しました。");
            return;
        }

        for (int i = 0; i < _soundObjParam.Params[_poolCountIndex].MaxCount; i++)
        {
            var sound = Instantiate(_soundObjParam.Params[_poolCountIndex].Prefab, this.transform);
            sound.SetActive(false);
            _pool.Add(new Pool { Object = sound, Name = _soundObjParam.Params[_poolCountIndex].Name });
        }

        _poolCountIndex++;
        CreatePool();
    }

    /// <summary>
    /// 効果音を使いたいときに呼び出す関数
    /// </summary>
    /// <param name="name">流したいサウンドの名前</param>
    /// <returns></returns>
    public GameObject UseSFX(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            Debug.LogWarning("効果音が指定されていません");
            return null;
        }

        foreach (var pool in _pool)
        {
            if (pool.Object.activeSelf == false && pool.Name == name)
            {
                pool.Object.SetActive(true);
                return pool.Object;
            }
        }

        if (_soundObjParam.Params.Find(x => x.Name == name) == null)
        {
            Debug.LogError($"{name}というサウンドが見つかりませんでした 誤字又は設定のし忘れがあります。");
            return null;
        }

        var newSound = Instantiate(_soundObjParam.Params.Find(x => x.Name == name).Prefab, this.transform);
        _pool.Add(new Pool { Object = newSound, Name = name });
        newSound.SetActive(true);
        return newSound;
    }

    private class Pool
    {
        public GameObject Object { get; set; }
        public string Name { get; set; }
    }
}

[System.Serializable]
public class SoundPoolParams
{
    public List<SoundPoolParam> Params => soundPoolParams;
    [SerializeField] public List<SoundPoolParam> soundPoolParams = new List<SoundPoolParam>();
}


[System.Serializable]
public class SoundPoolParam
{
    public string Name => name;
    public GameObject Prefab => prefab;
    public int MaxCount => maxCount;

    [SerializeField]
    private string name;
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private int maxCount;
}