# Protocol Activation sample

プロトコルアクティベーション機能を利用して、業務アプリケーションから「バーコード マネージャー for Business」アプリを起動し、バーコードの読み取り、結果の取得（表示）を行うサンプルです。
> **Note:** サンプルアプリケーションの実行には、[バーコード マネージャー for Business](https://www.microsoft.com/store/apps/9PF2KPXK63NM) または
> [バーコード マネージャー for Business Basic](https://www.microsoft.com/store/apps/9N15FGRXW88B) アプリがPCにインストールされている必要があります。

> **重要:** 現在、アプリバージョン3.x以降ではこの機能は利用できません。 

![BMBizHelp121](https://user-images.githubusercontent.com/29191374/111261560-ff6bb600-8665-11eb-9e8d-0a18e3af0e90.png)

このサンプルには以下の内容が含まれます
* Windows.System.Launcher.LaunchUriForResultsAsyncメソッドを使用したアプリのアクティベーション
* URIのパラメータによる、使用するメディア（カメラ、ファイル、画面領域の切り取り）の指定方法
* アプリからの結果（バーコードデータ）の取得方法

## 使用方法
* リポジトリをクローンまたはZipファイルをダウンロードして任意のフォルダに展開します。
* Visual Studioを起動し、プロジェクトファイルまたはソリューションファイルを開きます。
* ビルド > ソリューションのビルドを実行し、F5キーでデバッグを開始します。

起動したサンプルアプリ画面で以下の手順を行います。
* 起動する「バーコード マネージャー」アプリを選択します。
* 使用する読み取り手段（カメラ、ファイル、切り取り）のボタンを押して「バーコード マネージャー」アプリを起動します。
* 起動した「バーコード マネージャー」アプリでバーコードを読み取ります。
* サンプルアプリの画面に読み取ったバーコードの情報が表示れます。

> **追加情報:** 「バーコード マネージャー for Business」アプリからは常に１件のバーコード読み取り結果が返されます。 

## リファレンス
### URI Scheme
#### barcodemgr:reader?source={source} 
**source:** camera | file | clip

#### 例
**barcodemgr:reader?source=camera :** カメラモードで起動

**barcodemgr:reader?source=file :** ファイル選択モードで起動

**barcodemgr:reader?source=clip :** 画面領域の切り取りモードで起動 

> **Note:** 「バーコード マネージャー」アプリのパッケージファミリ名は次の通りです。  
>**バーコード マネージャー for Business:** 42795blueyachtsoftware.BarcodeManagerforBusiness_4aw44ckj2xyg8  
>**バーコード マネージャー for Business Basic:** 42795blueyachtsoftware.BarcodeManagerforBusinessBa_4aw44ckj2xyg8
  
### 対象のフレームワーク
* Windows 10 SDK Version 1903, 2004
