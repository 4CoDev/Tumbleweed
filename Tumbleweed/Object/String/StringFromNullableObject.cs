using Tumbleweed.Nullable.From.System;
using Tumbleweed.String;
using Tumbleweed.String.From.System.Nullable;

namespace Tumbleweed.Object.String;

public sealed class StringFromAnyObject : Nullable.Envelope<Any>
{
	public StringFromAnyObject(System.Object? @object) : this
	(
		new One<System.Object>(@object)
	)
	{
	}
	
	public StringFromAnyObject(Nullable.Any<System.Object> @object) : base
	(
		new One(
				new Scalar.Function.Result<System.String?>(
					@object.ToString))
	)
	{
	}
}