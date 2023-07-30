using Godot;
using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.From.Enumerable;
using Tumbleweed.Scalar.Immutable.Nested;
using Tumbleweed.Scalar.Immutable.Of;
using Scalar = Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool
	.OfGodot.FromEnumerable;

public sealed class AggregatedByExpression<TFrom>
	: Envelope<SurfaceTool>
{
	public AggregatedByExpression
	(
		IEnumerable<TFrom> from,
		Any<SurfaceTool> seed,
		Func<Any<SurfaceTool>, TFrom, Any<SurfaceTool>> func
	) : base
	(
		new Value<SurfaceTool>(
			new Aggregated<TFrom, Any<SurfaceTool>>(
				from,
				seed, 
				func))
	)
	{
	}
}