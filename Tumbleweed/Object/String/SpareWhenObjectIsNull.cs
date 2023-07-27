using Tumbleweed.Nullable.From.System;
using Tumbleweed.String;
using Tumbleweed.String.From.System.NonNullable;

namespace Tumbleweed.Object.String;

public sealed class SpareWhenObjectIsNull : Envelope
{
	public SpareWhenObjectIsNull
	(
		System.Object? @object,
		System.String spare
	) : this
	(
		new One<System.Object>(@object),
		new Tumbleweed.Scalar.Of.Value<System.String>(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(Nullable.Any<System.Object> @object,
		System.String spare
	) : this
	(
		@object,
		new Tumbleweed.Scalar.Of.Value<System.String>(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(
		System.Object? @object, Scalar.Any<System.String> spare
	) : this
	(
		new One<System.Object>(@object),
		new One(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(Nullable.Any<System.Object> @object,
		Any spare
	) : base
	(
		new Tumbleweed.String.Spare.When.Null.One(
			new StringFromAnyObject(@object),
			spare)
	)
	{
	}
}