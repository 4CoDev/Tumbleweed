using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;
using Boolean = Tumbleweed.Boolean;

namespace Tumbleweed.Scalar.Immutable;

public sealed class Conditional<T> : Immutable::Envelope<T>
{
	public Conditional
	(
		System::Boolean condition,
		T then,
		T otherwise
	) : this
	(
		new Boolean::From.System.One(condition),
		then,
		otherwise
	)
	{
	}
	
	public Conditional
	(
		System::Boolean condition,
		Immutable::Any<T> then,
		Immutable::Any<T> otherwise
	) : this
	(
		new Boolean::From.System.One(condition),
		then,
		otherwise
	)
	{
	}

	public Conditional
	(
		Boolean::Any condition,
		T then,
		T otherwise
	) : this
	(
		condition,
		new Immutable::With.Value<T>(then),
		new Immutable::With.Value<T>(otherwise)
	)
	{
	}
	
	public Conditional
	(
		Boolean::Any condition,
		Immutable::Any<T> then,
		Immutable::Any<T> otherwise
	) : base
	(
		new Immutable::Function.Result.Actual<T>(
			() => Function(condition, then, otherwise))
	)
	{
	}

	private static T Function
	(
		Boolean::Any condition,
		Immutable::Any<T> then,
		Immutable::Any<T> otherwise
	)
	{
		if (condition.State) return then.Value;
		return otherwise.Value;
	}
}