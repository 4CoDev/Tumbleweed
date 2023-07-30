using Tumbleweed.Boolean;
using Tumbleweed.Boolean.From.System;
using Tumbleweed.Scalar.Immutable;
using Scalar = Tumbleweed.Scalar;

namespace DotGod.Spatial._Node.Batch;

public sealed class Conditional : Batch.Envelope
{
	public Conditional
	(
		Boolean condition,
		Batch.Any then,
		Batch.Any otherwise
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
		Tumbleweed.Boolean.Any condition,
		Batch.Any then,
		Batch.Any otherwise
	) : base
	(
		new Value.Of.Scalar(
			new Conditional<Batch.Any>(
				condition,
				then,
				otherwise))
	)
	{
	}
}