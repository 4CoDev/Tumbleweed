using Godot;
using Tumbleweed.Scalars;
using Tumbleweed.Scalars.FromEnumerable;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.FromEnumerable;

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
		new ScalarOfDoubleScalar<SurfaceTool>(
			new AggregatedByExpression<TFrom, IScalar<SurfaceTool>>(from, seed, func))
	)
	{
	}
}