using Tumbleweed.Boolean;
using Tumbleweed.Boolean.From.System;
using System = System;

namespace Tumbleweed.Scalar;

public sealed class Conditional<T> : Scalar.Envelope<T>
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
		Scalar.Any<T> then,
		Scalar.Any<T> otherwise
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
		new Scalar.Of.Value<T>(then),
		new Scalar.Of.Value<T>(otherwise)
	)
	{
	}
	
	public Conditional
	(
		Any condition,
		Scalar.Any<T> then,
		Scalar.Any<T> otherwise
	) : base
	(
		new Function.Result<T>(
			() => Function(condition, then, otherwise))
	)
	{
	}

	private static T Function
	(
		Any condition,
		Any<T> then,
		Any<T> otherwise
	)
	{
		if (condition.State) return then.Value;
		return otherwise.Value;
	}
}