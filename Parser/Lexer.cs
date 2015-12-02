using System;
using System.Collections.Generic;
using System.Text;

namespace jsmix.Parser
{

	
	public class Lexer
	{
		private static HashSet<string> _keywords;
		private static HashSet<string> _strictModeReservedWords;
		private static HashSet<string> _futureReservedWords;

		private int _index; // position in the stream
		private int _length; // length of the stream
		private int _lineNumber;
		private int _lineStart;
		private CodeSegment _segment;
		private Token _lookahead;
		private string _source;

		private State _state;
		private bool _strict;

		static Lexer()
		{
			_keywords = new HashSet<string>();
			_keywords.Add("break");
			_keywords.Add("case");
			_keywords.Add("catch");
			_keywords.Add("class");
			_keywords.Add("const");
			_keywords.Add("continue");
			_keywords.Add("debugger");
			_keywords.Add("default");
			_keywords.Add("delete");
			_keywords.Add("do");
			_keywords.Add("else");
			_keywords.Add("enum");
			_keywords.Add("export");
			_keywords.Add("extends");
			_keywords.Add("finally");
			_keywords.Add("for");
			_keywords.Add("function");
			_keywords.Add("if");
			_keywords.Add("import");
			_keywords.Add("in");
			_keywords.Add("instanceof");
			_keywords.Add("let");
			_keywords.Add("new");
			_keywords.Add("return");
			_keywords.Add("super");
			_keywords.Add("switch");
			_keywords.Add("this");
			_keywords.Add("throw");
			_keywords.Add("try");
			_keywords.Add("typeof");
			_keywords.Add("var");
			_keywords.Add("void");
			_keywords.Add("while");
			_keywords.Add("with");
			_keywords.Add("yield");

			_strictModeReservedWords = new HashSet<string>();
			_strictModeReservedWords.Add("implements");
			_strictModeReservedWords.Add("interface");
			_strictModeReservedWords.Add("package");
			_strictModeReservedWords.Add("private");
			_strictModeReservedWords.Add("protected");
			_strictModeReservedWords.Add("public");
			_strictModeReservedWords.Add("static");
			_strictModeReservedWords.Add("yield");
			_strictModeReservedWords.Add("let");

			_futureReservedWords = new HashSet<string>();
			_futureReservedWords.Add("class");
			_futureReservedWords.Add("enum");
            _futureReservedWords.Add("export");
            _futureReservedWords.Add("extends");
            _futureReservedWords.Add("import");
            _futureReservedWords.Add("super");
		}


	}
}
