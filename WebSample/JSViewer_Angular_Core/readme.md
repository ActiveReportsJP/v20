# JSビューワ Angular サンプル

AngularとASP.NET Coreを利用して、JSビューワを使用するサンプルです。

## 必要システム

このサンプルをご利用いただくために以下のアプリケーションが必要です。
* [Visual Studio 2026](https://visualstudio.microsoft.com/vs/) 18.0 以降
* [.NET 10.0 SDK](https://www.microsoft.com/net/download)
* [.NET Core Hosting Bundle](https://dotnet.microsoft.com/download/dotnet/thank-you/runtime-aspnetcore-10.0.0-windows-hosting-bundle-installer) (IIS展開用)
* [Node.js](https://nodejs.org) 22.x 以降

## サンプルのビルド手順

1. Visual Studioを起動し、**ファイル → 開く → プロジェクト/ソリューション**を選択します。
2. サンプルフォルダを開き、Visual Studioソリューションファイル(.sln)を選択します。
3. ソリューションエクスプローラーでソリューションを右クリックし、**NuGetパッケージの復元**を選択します。
4. コマンド プロンプトを開き、..\JSViewer_Angular_Core.Clientフォルダーに移動します。
5. `npm install` コマンドを実行します。
6. **ビルド → ソリューションのビルド**を選択し、ビルドを実行します。

## サンプルの実行

サンプルをデバッグ実行するには、ソリューションエクスプローラーでJSViewer_Angular_Core.Serverプロジェクトを右クリックし、**スタートアップ プロジェクトに設定**を選択してから、**デバッグ → デバッグの開始**を選択します。
デバッグせずにサンプルを実行するには**デバッグ → デバッグなしで開始**を選択します。