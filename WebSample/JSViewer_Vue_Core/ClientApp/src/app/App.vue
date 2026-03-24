<template>
    <div class="page-container">
        <ReportList :reportList="reportList"
                    :selectedReport="selectedReport"
                    :selectReport="selectReport" />
        <Viewer :reportName="selectedReportName" />
    </div>
</template>
<script>
    import ReportList from './components/ReportList.vue';
    import Viewer from './components/Viewer.vue';

    export default {
        name: 'app',
        components: {
            ReportList, Viewer
        },
        data() {
            return {
                reportList: [],
                selectedReport: null
            };
        },
        computed: {
            selectedReportName() {
                if (!this.selectedReport)
                    return null;

                return this.selectedReport.useSnapshot
                    ? this.selectedReport.snapshotName
                    : this.selectedReport.name;
            }
        },
        created() {
            fetch('reports')
                .then(response => response.json())
                .then(result => {
                    if (result.length > 0) {
                        result.forEach(function (report) {
                            report.useSnapshot = report.hasSnapshot;
                        });
                        this.selectedReport = result[0];
                        this.reportList = result;
                    }
                })
                .catch(e => {
                    console.log(e);
                });
        },
        methods: {
            selectReport(report) {
                this.selectedReport = report;
            }
        }
    }
</script>
<style>
    .page-container {
        display: flex;
    }
</style>