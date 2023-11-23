using Tumbleweed.Property.Nullable;
using Tumbleweed.Property.Nullable.From.System;

namespace Tumbleweed.String.Operation.Empty.When.Null;

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