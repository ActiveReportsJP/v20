# JSビューワ ReactJSフック サンプル

このサンプルはJavaScriptフレームワークReactのフック機能と、ASP.NET Coreを利用してJSビューワを使用するサンプルです。

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
4. コマンドプロンプトを開き、JSViewer_React_Hooks\JSViewer_React_Hooks.Clientフォルダに移動します。
5. npm install コマンドを実行します。
6. **ビルド → ソリューションのビルド**を選択し、ビルドを実行します。

## サンプルの実行

サンプルをデバッグ実行するには、ソリューションエクスプローラーでソリューションを右クリックし、「プロパティ」を選択します。スタートアッププロジェクトの設定が「複数のスタートアップ プロジェクト」に設定されていることを確認し、JSViewer_React_Hooks.Server プロジェクトとJSViewer_React_Hooks.Client プロジェクトの両方のアクションを「開始」に設定します。JSViewer_React_Hooks.Serverがリストの先頭にあることを確認し、**デバッグ → デバッグの開始**を選択します。
デバッグせずにサンプルを実行するには**デバッグ → デバッグなしで開始**を選択します。
