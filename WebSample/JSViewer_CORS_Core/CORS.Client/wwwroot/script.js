import { createViewer } from './jsViewer.min.js';

const serverUrl = 'http://localhost:50221/';

function selectReportElement(report) {
    const reportsList = document.getElementById("reportsList");
    const reports = reportsList.children;

    for (let i = 0; i < reports.length; i++) {
        if (reports[i].children[0].innerText === report.name)
            reports[i].classList.add('active');
        else
            reports[i].classList.remove('active');
    }
}

function getReports() {
    return fetch(serverUrl + "reports")
        .then(response => response.json())
        .catch(error => {
            console.error("Error fetching reports:", error);
            return [];
        });
}

function fillReportsList(reports) {
    const reportsList = document.getElementById("reportsList");
    reportsList.innerHTML = "";
    for (let i = 0; i < reports.length; i++) {
        const report = reports[i];
        const reportElement = document.createElement('li');
        reportElement.className = 'navbar-item';
        const title = document.createElement('span');
        title.innerText = report.name;
        reportElement.appendChild(title);
        if (report.hasSnapshot) {
            const checkbox = document.createElement('input');
            checkbox.type = 'checkbox';
            checkbox.checked = true;
            checkbox.title = '最新のスナップショットを開く';
            checkbox.addEventListener('click', function (event) {
                if (reportElement.className != 'navbar-item active') {
                    event.stopPropagation();
                }
            });
            reportElement.appendChild(checkbox);
        }

        reportsList.appendChild(reportElement);

        reportElement.addEventListener('click', function () {
            openReport(report, report.hasSnapshot && reportElement.children[1].checked);
        });
    }
}

function openReport(report, openSnapshot) {
    viewer.openReport(openSnapshot ? report.snapshotName : report.name);
    selectReportElement(report);
}

const viewer = createViewer({
    element: '#viewerContainer',
    reportService: {
        url: serverUrl + 'api/reporting',
        onRequest: (init) => {
            init.credentials = 'omit';
        }
    }
});

getReports().then(reports => {
    if (reports.length > 0) {
        fillReportsList(reports);
        openReport(reports[0], reports[0].hasSnapshot);
    }
});