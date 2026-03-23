import React, { Component } from "react";

export default class ReportList extends Component {
    render() {
        return (
            <div className="sidebar-container">
                <div className="sidebar-header">レポートの選択</div>
                <div className="horizontal-separator"></div>
                <ul className="navbar" id="reportsList">
                    {this.props.items.map(report => (
                        <li className={"navbar-item" + (report.name === this.props.selectedReport.name ? " active" : "")}
                            key={report.name} onClick={() => {
                                this.props.selectReport(report);
                            }}>
                            <span>{report.name}</span>
                            <input type="checkbox" style={{ display: report.hasSnapshot ? 'block' : 'none' }} defaultChecked={report.useSnapshot} onClick={(event) => {
                                event.stopPropagation();
                                this.props.checkReport(report);
                            }} title="最新のスナップショットを開く" />
                        </li>
                    ))}
                </ul>
            </div>
        );
    }
}