using Tumbleweed.Boolean.From.System;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Node.Spatial.Batch;

public sealed class Conditional : Envelope
{
	public Conditional
	(
		Boolean condition,
		Any then,
		Any otherwise
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
		Any then,
		Any otherwise
	) : base
	(
		new DotGod.Spatial._Node.Batch.Value.Of.Scalar(
			new Conditional<Any>(
				condition,
				then,
				otherwise))
	)
	{
	}
}