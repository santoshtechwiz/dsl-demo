//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\temp\Orsted.WindTurbine.DSL\Turbine.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class TurbineLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, STRING=8, NUMBER=9, 
		DATE=10, TIME=11, SEPARATOR=12, COLON=13, TEXT=14, MONTH=15, WS=16;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "STRING", "NUMBER", 
		"DATE", "TIME", "SEPARATOR", "COLON", "TEXT", "MONTH", "WS"
	};


	public TurbineLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public TurbineLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'Defect:'", "'at'", "'{'", "'}'", "'SITE'", "','", "'Position'", 
		null, null, null, null, "'-'", "':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, "STRING", "NUMBER", "DATE", 
		"TIME", "SEPARATOR", "COLON", "TEXT", "MONTH", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Turbine.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static TurbineLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static int[] _serializedATN = {
		4,0,16,151,6,-1,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,
		6,2,7,7,7,2,8,7,8,2,9,7,9,2,10,7,10,2,11,7,11,2,12,7,12,2,13,7,13,2,14,
		7,14,2,15,7,15,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,0,1,1,1,1,1,1,1,2,1,2,1,3,
		1,3,1,4,1,4,1,4,1,4,1,4,1,5,1,5,1,6,1,6,1,6,1,6,1,6,1,6,1,6,1,6,1,6,1,
		7,1,7,5,7,67,8,7,10,7,12,7,70,9,7,1,7,1,7,1,8,4,8,75,8,8,11,8,12,8,76,
		1,9,1,9,1,9,1,9,1,9,1,9,1,9,1,10,1,10,1,10,1,10,1,10,1,10,1,11,1,11,1,
		12,1,12,1,13,4,13,97,8,13,11,13,12,13,98,1,13,5,13,102,8,13,10,13,12,13,
		105,9,13,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,
		14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,
		14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,1,14,3,14,143,8,14,1,15,4,15,
		146,8,15,11,15,12,15,147,1,15,1,15,0,0,16,1,1,3,2,5,3,7,4,9,5,11,6,13,
		7,15,8,17,9,19,10,21,11,23,12,25,13,27,14,29,15,31,16,1,0,4,4,0,10,10,
		13,13,34,34,92,92,1,0,48,57,2,0,65,90,97,122,3,0,9,10,13,13,32,32,166,
		0,1,1,0,0,0,0,3,1,0,0,0,0,5,1,0,0,0,0,7,1,0,0,0,0,9,1,0,0,0,0,11,1,0,0,
		0,0,13,1,0,0,0,0,15,1,0,0,0,0,17,1,0,0,0,0,19,1,0,0,0,0,21,1,0,0,0,0,23,
		1,0,0,0,0,25,1,0,0,0,0,27,1,0,0,0,0,29,1,0,0,0,0,31,1,0,0,0,1,33,1,0,0,
		0,3,41,1,0,0,0,5,44,1,0,0,0,7,46,1,0,0,0,9,48,1,0,0,0,11,53,1,0,0,0,13,
		55,1,0,0,0,15,64,1,0,0,0,17,74,1,0,0,0,19,78,1,0,0,0,21,85,1,0,0,0,23,
		91,1,0,0,0,25,93,1,0,0,0,27,96,1,0,0,0,29,142,1,0,0,0,31,145,1,0,0,0,33,
		34,5,68,0,0,34,35,5,101,0,0,35,36,5,102,0,0,36,37,5,101,0,0,37,38,5,99,
		0,0,38,39,5,116,0,0,39,40,5,58,0,0,40,2,1,0,0,0,41,42,5,97,0,0,42,43,5,
		116,0,0,43,4,1,0,0,0,44,45,5,123,0,0,45,6,1,0,0,0,46,47,5,125,0,0,47,8,
		1,0,0,0,48,49,5,83,0,0,49,50,5,73,0,0,50,51,5,84,0,0,51,52,5,69,0,0,52,
		10,1,0,0,0,53,54,5,44,0,0,54,12,1,0,0,0,55,56,5,80,0,0,56,57,5,111,0,0,
		57,58,5,115,0,0,58,59,5,105,0,0,59,60,5,116,0,0,60,61,5,105,0,0,61,62,
		5,111,0,0,62,63,5,110,0,0,63,14,1,0,0,0,64,68,5,34,0,0,65,67,8,0,0,0,66,
		65,1,0,0,0,67,70,1,0,0,0,68,66,1,0,0,0,68,69,1,0,0,0,69,71,1,0,0,0,70,
		68,1,0,0,0,71,72,5,34,0,0,72,16,1,0,0,0,73,75,7,1,0,0,74,73,1,0,0,0,75,
		76,1,0,0,0,76,74,1,0,0,0,76,77,1,0,0,0,77,18,1,0,0,0,78,79,3,17,8,0,79,
		80,3,17,8,0,80,81,3,23,11,0,81,82,3,29,14,0,82,83,3,23,11,0,83,84,3,17,
		8,0,84,20,1,0,0,0,85,86,3,17,8,0,86,87,3,17,8,0,87,88,3,25,12,0,88,89,
		3,17,8,0,89,90,3,17,8,0,90,22,1,0,0,0,91,92,5,45,0,0,92,24,1,0,0,0,93,
		94,5,58,0,0,94,26,1,0,0,0,95,97,7,2,0,0,96,95,1,0,0,0,97,98,1,0,0,0,98,
		96,1,0,0,0,98,99,1,0,0,0,99,103,1,0,0,0,100,102,7,1,0,0,101,100,1,0,0,
		0,102,105,1,0,0,0,103,101,1,0,0,0,103,104,1,0,0,0,104,28,1,0,0,0,105,103,
		1,0,0,0,106,107,5,74,0,0,107,108,5,65,0,0,108,143,5,78,0,0,109,110,5,70,
		0,0,110,111,5,69,0,0,111,143,5,66,0,0,112,113,5,77,0,0,113,114,5,65,0,
		0,114,143,5,82,0,0,115,116,5,65,0,0,116,117,5,80,0,0,117,143,5,82,0,0,
		118,119,5,77,0,0,119,120,5,65,0,0,120,143,5,89,0,0,121,122,5,74,0,0,122,
		123,5,85,0,0,123,143,5,78,0,0,124,125,5,74,0,0,125,126,5,85,0,0,126,143,
		5,76,0,0,127,128,5,65,0,0,128,129,5,85,0,0,129,143,5,71,0,0,130,131,5,
		83,0,0,131,132,5,69,0,0,132,143,5,80,0,0,133,134,5,79,0,0,134,135,5,67,
		0,0,135,143,5,84,0,0,136,137,5,78,0,0,137,138,5,79,0,0,138,143,5,86,0,
		0,139,140,5,68,0,0,140,141,5,69,0,0,141,143,5,67,0,0,142,106,1,0,0,0,142,
		109,1,0,0,0,142,112,1,0,0,0,142,115,1,0,0,0,142,118,1,0,0,0,142,121,1,
		0,0,0,142,124,1,0,0,0,142,127,1,0,0,0,142,130,1,0,0,0,142,133,1,0,0,0,
		142,136,1,0,0,0,142,139,1,0,0,0,143,30,1,0,0,0,144,146,7,3,0,0,145,144,
		1,0,0,0,146,147,1,0,0,0,147,145,1,0,0,0,147,148,1,0,0,0,148,149,1,0,0,
		0,149,150,6,15,0,0,150,32,1,0,0,0,7,0,68,76,98,103,142,147,1,0,1,0
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
