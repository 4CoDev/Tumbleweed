using DotGod.Geometry.Spatial.Concave.Graphical.Polygon.With.Vertex.Enumerable;
using Godot;
using Tumbleweed.Scalar.Immutable;
using Enumerable = DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index.Vertex.Enumerable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.Polygon.Triangle.FromGodot.FromSurface;

public sealed class TriangleWithVertexIndices : Envelope
{
	public TriangleWithVertexIndices
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface,
		IEnumerable<Int32> indices) : base
	(
		new One(
			new Enumerable(mesh, surface, indices))
	)
	{
	}
}