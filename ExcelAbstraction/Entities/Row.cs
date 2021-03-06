﻿using System.Collections.Generic;

namespace ExcelAbstraction.Entities
{
	public class Row
	{
		public int Index { get; private set; }
		public IEnumerable<Cell> Cells { get; private set; }

		public Row(int index, IEnumerable<Cell> cells)
		{
			Index = index;
			Cells = cells;
		}
	}
}