# [SoundManager](https://github.com/ItoSeiy/Demension/blob/main/Assets/Script/Sound/SoundManager.cs)の使用方法

**サウンドマネージャーは効果音, BGMを管理,再生するものです**
分からないことがあったら伊東までお願いします

サウンドマネージャーのパスです

<img src= "https://user-images.githubusercontent.com/89116872/159146777-bfffa271-43d2-45c5-b56e-342e837536bf.png" width="300" align="top">

サウンドを設定する際には上記のプレハブをだれか1人が編集するようにお願いします。

## 効果音の設定方法

<img src="https://user-images.githubusercontent.com/89116872/159146906-681ad028-de4d-4db5-8c4a-02ddacc98b38.png" width="300" align="top">赤い枠内に効果音を設定していく形になります。

Name は 効果音の名前を入力して下さい(音を流す際アクセスするキーワードになります)

Prefab は [効果音が流れるプレハブ](https://github.com/ItoSeiy/Demension/blob/main/HowToUse/SoundManager.MD#%E5%8A%B9%E6%9E%9C%E9%9F%B3%E3%81%AE%E3%83%97%E3%83%AC%E3%83%8F%E3%83%96%E3%81%AE%E8%A8%AD%E5%AE%9A%E6%96%B9%E6%B3%95)を設定します(後述します)

MaxCountについては10ほどで大丈夫です

## 効果音のプレハブの設定方法

<img src= "https://user-images.githubusercontent.com/89116872/159148376-ea7b8ff6-1144-4c0d-9b09-04e307df4742.png" width="500" align="top">このようにプレハブを作成していく形になります。

1. SoundManagerExampleを複製してください(Ctrlキー + Dキー)

2. 名前を効果音の設定で行った Nameと同じ名前にしてください

3.効果音のオーディオクリップを設定し、下記画像のようにPlayOnAwakeにチェックが入っていることを確認してください
<img src= "https://user-images.githubusercontent.com/89116872/159149118-857fa167-bab5-4eb3-b26c-19ab0d474f07.png" width="200" align="top">

4. [SoundManagerの設定](https://github.com/ItoSeiy/Demension/blob/main/HowToUse/SoundManager.MD#%E5%8A%B9%E6%9E%9C%E9%9F%B3%E3%81%AE%E8%A8%AD%E5%AE%9A%E6%96%B9%E6%B3%95)への設定を忘れないようにお願いします

## BGM の設定方法

<img src= "https://user-images.githubusercontent.com/89116872/159148809-7bf2da74-b2bf-498d-8b96-65505da4dbfa.png" width="300" align="top">このプレハブをBGMの流したいシーンに1つ配置する方になります

===設置後===

<img src= "https://user-images.githubusercontent.com/89116872/159148937-6f1c7246-2611-452b-af91-fb28f6f8b46f.png" width="300" align="top">

**設置後に**流したいBGMのオーディクリップと音量を設定して完了です
