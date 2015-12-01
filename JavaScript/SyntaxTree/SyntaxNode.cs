using System;
using System.Collections.Generic;
using System.Text;
using jsmix.Parser;
namespace jsmix.JavaScript.SyntaxTree
{
	public class SyntaxNode
	{
		public SyntaxNode(SyntaxNodeType type, int[] span)
		{
			this.Type = type;
			this.Span = span;
		}
		CodeSegment Segment { get; set; }
		SyntaxNodeType Type { get; set; }
		public int[] Span { get; set; }
		public T To<T>() where T : SyntaxNode
		{
			return (T)this;
		}
	}
}
