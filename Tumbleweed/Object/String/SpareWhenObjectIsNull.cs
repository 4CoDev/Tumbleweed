using Tumbleweed.Property.Nullable;
using Tumbleweed.Property.Nullable.From.System;
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
		new Property.Output.With.Value.One<System.String>(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(Any<System.Object> @object,
		System.String spare
	) : this
	(
		@object,
		new Property.Output.With.Value.One<System.String>(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(
		System.Object? @object, Property.Output.Any<System.String> spare
	) : this
	(
		new One<System.Object>(@object),
		new One(spare)
	)
	{
	}
	
	public SpareWhenObjectIsNull
	(Any<System.Object> @object,
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