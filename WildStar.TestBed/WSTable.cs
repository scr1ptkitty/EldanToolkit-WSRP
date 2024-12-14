using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WildStar.TestBed
{
    public abstract class WSTable : DataTable
    {
        public DataRow GetRowByIndex(int index)
        {
            if(rowIndex.TryGetValue(index, out int tableIndex))
                return Rows[tableIndex];
            return null;
        }
        public Dictionary<Index, int> rowIndex = new();

        protected void BuildIndex()
        {
            for (int i = 0; i < Rows.Count; i++)
            {
                rowIndex[(int)(Rows[i])[0]] = i;
            }
        }

        public abstract void Load(string path);
        public abstract void Save(string path);
    }
}
