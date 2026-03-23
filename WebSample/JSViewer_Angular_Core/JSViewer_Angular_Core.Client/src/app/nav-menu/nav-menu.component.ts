import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ReportDescriptor } from './ReportDescriptor';
import { RouterModule } from '@angular/router';
import { NgClass } from '@angular/common';

@Component({
    selector: 'app-nav-menu',
    templateUrl: './nav-menu.component.html',
    styleUrls: ['./nav-menu.component.css'],
    imports: [RouterModule, NgClass]
})

export class NavMenuComponent {
    isExpanded = false;

    public reports: ReportDescriptor[] = new Array<ReportDescriptor>();
    public ListTitle: string;

    collapse() {
        this.isExpanded = false;
    }

    toggle() {
        this.isExpanded = !this.isExpanded;
    }

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.ListTitle = 'JSビューワ - Angularサンプル';

        http.get<ReportDescriptor[]>(baseUrl + 'reports').subscribe({
            next: result => {
                this.reports = result;
                this.reports.forEach(function (report) {
                    report.useSnapshot = report.hasSnapshot;
                });
            },
            error: error => console.error(error)
        });
    }
}
