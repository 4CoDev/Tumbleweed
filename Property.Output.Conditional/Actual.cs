using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Property = Tumbleweed.Property.Output;
using System = System;


namespace Tumbleweed.Property.Output.Conditional;

public sealed class Actual<T> : Property::Envelope<T>
{
	public Actual
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
	
	public Actual
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

	public Actual
	(
		Any condition,
		T then,
		T otherwise
	) : this
	(
		condition,
		new Property::With.Value.One<T>(then),
		new Property::With.Value.One<T>(otherwise)
	)
	{
	}
	
	public Actual
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