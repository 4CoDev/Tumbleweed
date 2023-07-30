using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.From.System;

namespace Tumbleweed.String.Empty.When.Null;

public sealed class One : Envelope
{
	public One(System.String? nullable) : this
	(
		new One<System.String>(nullable)
	)
	{
	}
	
	public One(Any<System.String> nullable) : this
	(
		new From.System.Nullable.One(nullable)
	)
	{
	}
	
	public One(Any<Any> nullable) : base
	(
		new Spare.When.Null.One(nullable, "")
	)
	{
	}
}