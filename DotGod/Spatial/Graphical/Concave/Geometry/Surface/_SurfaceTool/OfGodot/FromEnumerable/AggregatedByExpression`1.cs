using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.FromEnumerable;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot.FromEnumerable;

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