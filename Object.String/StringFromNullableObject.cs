using Tumbleweed.Property.Output.Function.Result;
using Tumbleweed.Property.Option;
using Tumbleweed.Property.Option.From.System;
using Tumbleweed.String;
using Tumbleweed.String.From.System.Option;

namespace Tumbleweed.Object.String;

public sealed class StringFromAnyObject : Envelope<Any>
{
	public StringFromAnyObject(System.Object? @object) : this
	(
		new One<System.Object>(@object)
	)
	{
	}
	
	public StringFromAnyObject(Any<System.Object> @object) : base
	(
		new One(
				new Actual<System.String?>(
					@object.ToString))
	)
	{
	}
}