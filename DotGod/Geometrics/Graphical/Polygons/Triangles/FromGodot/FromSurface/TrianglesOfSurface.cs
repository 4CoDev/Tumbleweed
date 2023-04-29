using DotGod.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.FromSurface;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using VertexIndicesOfTriangles =
	DotGod.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.FromSurface.
	IndicesOfTriangles;

namespace DotGod.Geometrics.Graphical.Polygons.Triangles.FromGodot.
	FromSurface;

public sealed class TrianglesOfSurface
	: EnumerableEnvelope<IPolygon>
{
	public TrianglesOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	) : base
	(
		new TrianglesWithVertexIndices(
			mesh,
			surface,
			new IndicesOfTriangles(mesh, surface))
	)
	{
	}
}