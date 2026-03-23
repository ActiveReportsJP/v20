
export class ReportDescriptor {
    public name: string;
    public hasSnapshot: boolean;
    public snapshotName: string;
    public useSnapshot: boolean;

  constructor(name: string, hasSnapshot: boolean, snapshotName: string) {
        this.name = name;
        this.hasSnapshot = hasSnapshot;
        this.snapshotName = snapshotName;
        this.useSnapshot = hasSnapshot;
    }
};
