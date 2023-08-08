using DotGod.Node.Spatial.Batch.Entities;
using DotGod.Node.Spatial.Batch.Space;
using DotGod.Node.Spatial.Spaced.Abstract;
using DotGod.Spatial._Node.Batch.Result.Of;

namespace DotGod.Node.Spatial.Batch;

public sealed class SuitableOrInitial : Envelope
{
	public SuitableOrInitial
	(
		IBatch initial,
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
		IBatch initial,
		ISpace space
	) : base
	(
		new Conditional(
			new Have.Subbatch.By.From.Point.Of.Space(initial, space),
			new Function(() => Function(initial, space)),
			initial)
	)
	{
	}

	private static Any Function
	(
		IBatch initial,
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
		IBatch subbatch,
		ISpace space
	)
	{
		if (!new IsSpaceInsideBatch(subbatch, space).State) return initial;
		return new SuitableOrInitial(subbatch, space);
	}
}