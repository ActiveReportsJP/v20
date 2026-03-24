import * as React from "react";
import {reportContext} from "./reportProvider";

export const ReportsList: React.FC = () => {
    const reportProvider = React.useContext(reportContext);

    return (
        <div className="sidebar-container">
            <div className="sidebar-header">レポートを選択</div>
            <div className="horizontal-separator"></div>
            <ul className="navbar" id="reportsList">
                {reportProvider?.reportsList.map((report) => (
                    <li
                        className={
                            "navbar-item" +
                            (report.name === (reportProvider.currentReport?.name || "") ? " active" : "")
                        }
                        key={report.name}
                        onClick={() => {
                            reportProvider.setCurrentReport(report);
                        }}
                    >
                        <span>{report.name}</span>
                        <input type="checkbox" style={{ display: report.hasSnapshot ? 'block' : 'none' }} defaultChecked={report.useSnapshot} onClick={(event) => {
                                event.stopPropagation();
                                reportProvider.setCheckedReport(report);
                        }} title="最新のスナップショットを開く" />
                    </li>
                ))}
            </ul>
        </div>
    );
};
