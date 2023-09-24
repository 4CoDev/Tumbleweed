using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Node.Batch.Dimension.Spatial.Measurement.Measured;

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
		Tumbleweed.Mathematics.Boolean.Any condition,
		Any then,
		Any otherwise
	) : base
	(
		new Scalar.Value.One(
			new Conditional<Any>(
				condition,
				then,
				otherwise))
	)
	{
	}
}