using DotGod.Mathematics.Geometry.Stereometry.Graphical.Surface;
using Tumbleweed.Enumerable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.From.
	Surface;

public sealed class Enumerable
	: Envelope<Godot.SurfaceTool>
{
	public Enumerable(IEnumerable<Any> surfaces) : base
	(
		new Selected<Any, Godot.SurfaceTool>(
			surfaces,
			surface => new One(surface).Value)
	)
	{
	}
}