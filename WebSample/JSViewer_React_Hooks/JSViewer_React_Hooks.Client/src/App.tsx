import { ReportsList } from "./reportsList";
import { ReportViewer } from "./reportViewer";
import { ReportProvider, reportContext } from "./reportProvider";

function App() {
  return (
    <div className="page-container">
      <ReportProvider>
        <ReportsList />
        <reportContext.Consumer>
          {(val) => <ReportViewer reportId={val?.currentReportName || ""} />}
        </reportContext.Consumer>
      </ReportProvider>
    </div>
  );
}

export default App;
