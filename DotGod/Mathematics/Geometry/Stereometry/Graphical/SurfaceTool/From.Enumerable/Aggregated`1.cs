using Tumbleweed.Property.Output;
using Tumbleweed.Property.Output.From.Enumerable;
using Tumbleweed.Property.Output.Nested;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.From.Enumerable;

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