using System;
using System.Collections.Generic;
using System.Text;

namespace jsmix.Parser
{
	public class CodeSegment
	{
		public CodeSegment(Position start, Position end, string source)
		{
			this.Start = start;
			this.End = end;
			this.SourceCode = source;
		}
		public Position Start { get; set; }
		public Position End { get; set; }
		public string SourceCode { get; set; }
	}
}
