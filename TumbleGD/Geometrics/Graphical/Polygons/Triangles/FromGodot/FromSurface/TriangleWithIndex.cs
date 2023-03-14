using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using TumbleGD.Geometrics.Graphical.Vertices.FromArrayMesh.FromSurface;
using TumbleGD.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.FromSurface;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons.Triangles.FromGodot.FromSurface;

public sealed class TriangleWithIndex : EnumerableEnvelope<IVertex>
{
	public TriangleWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IScalar<Int32> triangle
	) : base
	(
		new VerticesWithIndices(
			mesh,
			surface,
			new IndicesOfTriangle(mesh, surface, triangle))
	)
	{
	}
}