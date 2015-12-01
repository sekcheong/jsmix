﻿using System;
using System.Collections.Generic;
using System.Text;

namespace jsmix.Parser
{
	public enum TokenType
	{
		 BooleanLiteral = 1,
        EOF = 2,
        Identifier = 3,
        Keyword = 4,
        NullLiteral = 5,
        NumericLiteral = 6,
        Punctuator = 7,
        StringLiteral = 8,
        RegularExpression = 9
	}
}