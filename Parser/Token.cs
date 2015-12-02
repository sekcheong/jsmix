using System;
using System.Collections.Generic;
using System.Text;

namespace jsmix.Parser
{
	public class Token
	{
		public static Token Empty = new Token();

		public TokenType Type;
		public string Literal;
		public object Value;
		public int[] Range;
		public int? LineNumber;
		public int LineStart;
		public bool Octal;
		public Codse Location;
		public int Precedence;
	}
}
