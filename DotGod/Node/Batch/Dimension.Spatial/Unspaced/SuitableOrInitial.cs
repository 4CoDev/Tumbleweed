using DotGod.Node.Batch.Dimension.Spatial.Spaced;
using DotGod.Node.Batch.Dimension.Spatial.Spaced.Subbatch.NonNullable.Collided.By.Space.Point.A;
using One = DotGod.Node.Batch.Dimension.Spatial.Unspaced.Function.Result.One;

namespace DotGod.Node.Batch.Dimension.Spatial.Unspaced;

public sealed class SuitableOrInitial : Envelope
{
	public SuitableOrInitial
	(
		Spaced.Any initial,
		Entity.Any entity
	) : this
	(
		initial,
		new Entity.Space.One(entity)
	)
	{
	}
	
	public SuitableOrInitial
	(
		Spaced.Any initial,
		Space.Any space
	) : base
	(
		new Conditional(
			new Have.Subbatch.Collided.By.Space.Point.A.One(initial, space),
			new One(() => Function(initial, space)),
			initial)
	)
	{
	}

	private static Any Function
	(
		Spaced.Any initial,
		Space.Any space
	) =>
	(
		Function(
			initial,
			new Spaced.Subbatch.NonNullable.Collided.By.Space.Point.A.One(initial, space),
			space)
	);
	
	private static Any Function
	(
		Any initial,
		Spaced.Any subbatch,
		Space.Any space
	)
	{
		if (!new Space.Is.Inside.Batch(subbatch, space).State) return initial;
		return new SuitableOrInitial(subbatch, space);
	}
}