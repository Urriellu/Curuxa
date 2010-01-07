using System;

namespace CuruxaIDE {
	public struct CursorLocation {
		public int Line;
		public int Column;

		public CursorLocation(int Line, int Column) {
			this.Line = Line;
			this.Column = Column;
		}
	}
}
