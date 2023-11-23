using Tumbleweed.Property.Option;
using Tumbleweed.Property.Option.From.System;

namespace Tumbleweed.String.Operation.Empty.When.Null;

public sealed class One : Envelope
{
	public One(System.String? option) : this
	(
		new One<System.String>(option)
	)
	{
	}
	
	public One(Any<System.String> option) : this
	(
		new From.System.Option.One(option)
	)
	{
	}
	
	public One(Any<Any> option) : base
	(
		new Spare.When.Null.One(option, "")
	)
	{
	}
}