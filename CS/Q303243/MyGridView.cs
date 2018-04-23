using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.XtraGrid.Views.Grid;

namespace Q303243 {
    public class MyGridView : GridView {
        public override bool IsExistAnyRowFooterCell(int rowHandle) {
            return true;
        }
    }
}
