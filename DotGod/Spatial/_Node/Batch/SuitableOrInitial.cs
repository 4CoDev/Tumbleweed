using DotGod.Spatial._Node.Batch.Entities;
using DotGod.Spatial._Node.Batch.Result.Of;
using DotGod.Spatial._Node.Batch.Space;

namespace DotGod.Spatial._Node.Batch;

public sealed class SuitableOrInitial : Envelope
{
	public SuitableOrInitial
	(
		Spaced.Abstract.IBatch initial,
		ISpatialEntity entity
	) : this
	(
		initial,
		new SpaceOfEntity(entity)
	)
	{
	}
	
	public SuitableOrInitial
	(
		Spaced.Abstract.IBatch initial,
		ISpace space
	) : base
	(
		new Conditional(
			new Batch.Have.Subbatch.By.From.Point.Of.Space(initial, space),
			new Function(() => Function(initial, space)),
			initial)
	)
	{
	}

	private static Any Function
	(
		Spaced.Abstract.IBatch initial,
		ISpace space
	) =>
	(
		Function(
			initial,
			new Spaced.Batch.Subbatch.By.From.Point.Of.Space(initial, space),
			space)
	);
	
	private static Any Function
	(
		Any initial,
		Spaced.Abstract.IBatch subbatch,
		ISpace space
	)
	{
		if (!new IsSpaceInsideBatch(subbatch, space).State) return initial;
		return new SuitableOrInitial(subbatch, space);
	}
}