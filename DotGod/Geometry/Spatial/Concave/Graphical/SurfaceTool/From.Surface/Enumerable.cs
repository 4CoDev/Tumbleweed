using DotGod.Geometry.Spatial.Concave.Graphical.Surface;
using Tumbleweed.Enumerable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.SurfaceTool.From.
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