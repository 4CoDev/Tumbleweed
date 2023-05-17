using DotGod.Geometry.Spatial.Graphical.Vertices;
using DotGod.Geometry.Spatial.Graphical.Vertices.FromArrayMesh.FromSurface;
using DotGod.Geometry.Spatial.Graphical.Vertices.Indices.FromArrayMesh.FromSurface;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Polygons.Triangles.FromGodot.FromSurface;

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