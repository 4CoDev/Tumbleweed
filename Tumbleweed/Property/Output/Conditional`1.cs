using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Property = Tumbleweed.Property.Output;
using System = System;


namespace Tumbleweed.Property.Output;

public sealed class Conditional<T> : Property::Envelope<T>
{
	public Conditional
	(
		System::Boolean condition,
		T then,
		T otherwise
	) : this
	(
		new One(condition),
		then,
		otherwise
	)
	{
	}
	
	public Conditional
	(
		System::Boolean condition,
		Property::Any<T> then,
		Property::Any<T> otherwise
	) : this
	(
		new One(condition),
		then,
		otherwise
	)
	{
	}

	public Conditional
	(
		Any condition,
		T then,
		T otherwise
	) : this
	(
		condition,
		new Property::With.Value<T>(then),
		new Property::With.Value<T>(otherwise)
	)
	{
	}
	
	public Conditional
	(
		Any condition,
		Property::Any<T> then,
		Property::Any<T> otherwise
	) : base
	(
		new Property::Function.Result.Actual<T>(
			() => Function(condition, then, otherwise))
	)
	{
	}

	private static T Function
	(
		Any condition,
		Property::Any<T> then,
		Property::Any<T> otherwise
	)
	{
		if (condition.State) return then.Value;
		return otherwise.Value;
	}
}