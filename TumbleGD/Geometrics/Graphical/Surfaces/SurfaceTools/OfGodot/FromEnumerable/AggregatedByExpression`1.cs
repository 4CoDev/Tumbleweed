using Godot;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace TumbleGD.Geometrics.Graphical.Surfaces.SurfaceTools.OfGodot.FromEnumerable;

public sealed class AggregatedByExpression<TFrom>
	: ScalarEnvelope<SurfaceTool>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		IScalar<SurfaceTool> seed,
		Func<IScalar<SurfaceTool>, TFrom, IScalar<SurfaceTool>> func
	) : base
	(
		new ScalarOfNested<SurfaceTool>(
			new AggregatedByExpression<TFrom, IScalar<SurfaceTool>>(from, seed, func))
	)
	{
	}
}