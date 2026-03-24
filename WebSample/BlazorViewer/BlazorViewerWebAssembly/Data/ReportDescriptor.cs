namespace BlazorViewerWebAssembly.Data
{
	public sealed class ReportDescriptor
	{
		public ReportDescriptor(string name, bool hasSnapshot, string snapshotName)
		{
			Name = name;
			HasSnapshot = hasSnapshot;
			SnapshotName = snapshotName;
		}

		public string Name { get; }
		public bool HasSnapshot { get; }
		public string SnapshotName { get; }
		public bool UseSnapshot { get; set; }
		public string GetReportName() => UseSnapshot ? SnapshotName : Name;
	}
}
