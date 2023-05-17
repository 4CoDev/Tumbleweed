using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using VertexIndicesOfTriangles =
	DotGod.Geometry.Spatial.Graphical.Vertices.Indices.FromArrayMesh.FromSurface.IndicesOfTriangles;

namespace DotGod.Geometry.Spatial.Graphical.Polygons.Triangles.FromGodot.
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
			new VertexIndicesOfTriangles(mesh, surface))
	)
	{
	}
}