using Tumbleweed.Scalar.Immutable;
using Tumbleweed.Scalar.Immutable.From.Enumerable;
using Tumbleweed.Scalar.Immutable.Nested;

namespace DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.From.Enumerable;

public sealed class Aggregated<TFrom>
	: Envelope<Godot.SurfaceTool>
{
	public Aggregated
	(
		IEnumerable<TFrom> from,
		Any<Godot.SurfaceTool> seed,
		Func<Any<Godot.SurfaceTool>, TFrom, Any<Godot.SurfaceTool>> func
	) : base
	(
		new Value<Godot.SurfaceTool>(
			new Aggregated<TFrom, Any<Godot.SurfaceTool>>(
				from,
				seed, 
				func))
	)
	{
	}
}