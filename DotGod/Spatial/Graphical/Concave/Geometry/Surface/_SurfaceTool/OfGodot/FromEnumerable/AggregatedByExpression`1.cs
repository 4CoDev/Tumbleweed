using Godot;
using Scalar = Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool
	.OfGodot.FromEnumerable;

public sealed class AggregatedByExpression<TFrom>
	: Scalar.Envelope<SurfaceTool>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		Scalar.Any<SurfaceTool> seed,
		Func<Scalar.Any<SurfaceTool>, TFrom, Scalar.Any<SurfaceTool>> func
	) : base
	(
		new Scalar.Of.Nested<SurfaceTool>(
			new Scalar.From.Enumerable.Aggregated<TFrom, Scalar.Any<SurfaceTool>>(
				from,
				seed, 
				func))
	)
	{
	}
}