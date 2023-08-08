using DotGod.Node.Spatial.Spaced.Batch.Of;
using Tumbleweed.Boolean;
using Tumbleweed.Boolean.From.System;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Node.Spatial.Spaced.Conditional;

public sealed class Batch : Spaced.Batch.Envelope
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