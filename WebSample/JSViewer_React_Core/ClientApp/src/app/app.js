import React, {Component} from "react";
import '../styles/app.css';
import Viewer from "./components/viewer";
import ReportList from "./components/reportList";

export default class App extends Component {
    constructor(props) {
        super(props);
        this.state = {
            reportsList: [],
            selectedReport: null,
            selectedReportName: null
        };
    }

    componentWillMount() {
        this.populateReports();
    }

    populateReports() {
        fetch('reports')
            .then(response => response.json())
            .then(result => {
                if (result.length > 0) {
                    result.forEach(function (report) {
                        report.useSnapshot = report.hasSnapshot;
                    });
                    this.setState({
                        selectedReport: result[0],
                        selectedReportName: result[0].useSnapshot ? result[0].snapshotName : result[0].name,
                        reportsList: result
                    });
                }
            })
            .catch(e => {
                console.log(e);
            });
    };

    selectReport = (report) => {
        this.setState({
            selectedReport: report,
            selectedReportName: report.useSnapshot ? report.snapshotName : report.name
        });
    };

    checkReport = (report) => {
        report.useSnapshot = !report.useSnapshot;
        if (!this.state || !this.state.selectedReport)
            return;
        if (report.name != this.state.selectedReport.name) {
            this.setState({
                reportsList: this.state.reportsList
            });
            return;
        }
        this.setState({
            selectedReport: report,
            selectedReportName: report.useSnapshot ? report.snapshotName : report.name
        });
    };

    render() {
        return (
            <div className="page-container">
                <ReportList items={this.state.reportsList}
                            selectedReport={this.state.selectedReport}
                            selectReport={this.selectReport}
                            checkReport={this.checkReport}
                />
                <Viewer reportName={this.state.selectedReportName}/>
            </div>
        );
    }
}