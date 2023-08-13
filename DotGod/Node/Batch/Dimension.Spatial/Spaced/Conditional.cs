using Tumbleweed.Boolean.From.System;
using Tumbleweed.Scalar.Immutable;
using Envelope = DotGod.Node.Batch.Dimension.Spatial.Spaced.Envelope;

namespace DotGod.Node.Batch.Dimension.Spatial.Spaced;

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
		new Scalar.Value.One(
			new Conditional<Any>(
				condition,
				then,
				otherwise))
	)
	{
	}
}