using Tumbleweed.Scalar.Immutable.Function.Result;
using Tumbleweed.Scalar.Nullable;
using Tumbleweed.Scalar.Nullable.From.System;
using Tumbleweed.String;
using Tumbleweed.String.From.System.Nullable;

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