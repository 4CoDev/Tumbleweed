using DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.Tool.From.ArrayMesh.Surface;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.Vertex.Index;

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