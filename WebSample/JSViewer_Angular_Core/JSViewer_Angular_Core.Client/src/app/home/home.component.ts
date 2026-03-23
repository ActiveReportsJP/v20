import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public Hello: string;
  public Wellcome: string;
  public Select: string;

  constructor() {
    this.Hello = 'こんにちは、お客様！';
    this.Wellcome = 'AngularアプリケーションのJS Viewerへようこそ';
    this.Select = 'プレビューするには、左側のパネルからレポートを選択してください。';

  }
}
