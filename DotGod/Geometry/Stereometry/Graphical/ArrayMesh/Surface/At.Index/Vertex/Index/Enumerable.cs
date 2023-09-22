using DotGod.Geometry.Stereometry.Graphical.SurfaceTool.Tool.From.ArrayMesh.Surface;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.Vertex.Index;

public sealed class Enumerable : Tumbleweed.Enumerable.Envelope<Int32>
{
	public Enumerable
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface
	) : base
	(
		new SurfaceTool.Vertex.Index.Enumerable(
			new ToolFromSurface(mesh, surface))
	)
	{
	}
}