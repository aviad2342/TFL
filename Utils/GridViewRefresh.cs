using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HW5.Utils
{
    static class GridViewRefresh
    {
        internal static void RefreshTable(BindingSource bs, DataGridView dataGridView, string tableName)
        {
            bs.DataSource = BuildTablesDGV.readData(tableName).Tables[0];
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = bs;
            dataGridView.Refresh();
        }

    }
}
