import * as React from 'react';

interface ReportDescriptor {
    name: string;
    hasSnapshot: boolean;
    snapshotName?: string;
    useSnapshot: boolean;
};

interface ReportProviderInterface{
    currentReportName: string;
    currentReport: ReportDescriptor | undefined;
    setCurrentReport: (id: ReportDescriptor) => void;
    setCheckedReport: (id: ReportDescriptor) => void;
    reportsList: ReportDescriptor[];
}

export const reportContext = React.createContext<ReportProviderInterface | undefined>(undefined);

export const ReportProvider: React.FC<{ children: any }> = ({ children }) => {
    const [currentReportName, setCurrentReportName] = React.useState("");
    const [currentReport, setCurrentReport] = React.useState<ReportDescriptor | undefined>(undefined);
    const [reportsList, setReportsList] = React.useState<ReportDescriptor[]>([]);
    React.useEffect(() => {
        const fetchReportsList = async (maxAttempts = 30, delay = 1000) => {
            for (let attempt = 0; attempt < maxAttempts; attempt++) {
            try {
                    const fetchResult = await fetch("reports").then((response) => response.json());
                setReportsList(fetchResult);
                if (fetchResult.length > 0) {
                    const id = fetchResult[0];
                    setCurrentReport(id);
                    setCurrentReportName(id.useSnapshot ? (id.snapshotName || "") : id.name);
                }

                    return true;
            } catch (err) {
                    console.warn(`Attempt ${attempt + 1}/${maxAttempts}. Error of fetching the report list`, err);
                    if (attempt < maxAttempts) {
                        await new Promise(resolve => setTimeout(resolve, delay));
                    } else {
                        throw new Error('API is not responding');
                    }
                }
            }
        };
        fetchReportsList();
      }, []);    
    const api: ReportProviderInterface = {
        currentReportName: currentReportName,
        currentReport: currentReport,
        setCurrentReport(id: ReportDescriptor) {
            setCurrentReport(id);
            setCurrentReportName(id.useSnapshot ? (id.snapshotName || "") : id.name);
        },
        setCheckedReport(id: ReportDescriptor) {
            id.useSnapshot = !id.useSnapshot;
            if (!currentReport)
                return;
            if (currentReport.name !== id.name) {
                return;
            }
            setCurrentReport(id);
            setCurrentReportName(id.useSnapshot ? (id.snapshotName || "") : id.name);
        },
        reportsList : reportsList
    }
    return <reportContext.Provider value={api}>
        {children}
    </reportContext.Provider>
}