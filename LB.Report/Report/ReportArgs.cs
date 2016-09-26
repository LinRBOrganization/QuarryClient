using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace LB.Report.Report
{
    public class ReportArgs
    {
        private DataView _DataSource = null;
        public DataView DataSource
        {
            get
            {
                return _DataSource;
            }
        }

        private DataRow _RecordDR = null;
        public DataRow RecordDR
        {
            get
            {
                return _RecordDR;
            }
        }

        private int _ReportTypeID;
        public long ReportTypeID
        {
            get
            {
                return _ReportTypeID;
            }
        }

        public ReportArgs(int iReportTypeID, DataView dvDataSource, DataRow recordDR)
        {
            this._DataSource = dvDataSource;
            this._RecordDR = recordDR;
            this._ReportTypeID = iReportTypeID;
        }
    }
}
