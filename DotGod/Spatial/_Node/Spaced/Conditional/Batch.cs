using DotGod.Spatial._Node.Spaced.Batch;
using DotGod.Spatial._Node.Spaced.Batch.Of;
using Tumbleweed.Boolean;
using Tumbleweed.Boolean.From.System;
using Tumbleweed.Scalar.Immutable;
using Envelope = DotGod.Spatial._Node.Spaced.Batch.Envelope;

namespace DotGod.Spatial._Node.Spaced.Conditional;

public sealed class Batch : Envelope
{
	public Batch
	(
		Boolean condition,
		Abstract.IBatch then,
		Abstract.IBatch otherwise
	) : this
	(
		new One(condition),
		then,
		otherwise
	)
	{
	}
	
	public Batch
	(
		Any condition,
		Abstract.IBatch then,
		Abstract.IBatch otherwise
	) : base
	(
		new Scalar(
			new Conditional<Abstract.IBatch>(
				condition,
				then,
				otherwise))
	)
	{
	}
}