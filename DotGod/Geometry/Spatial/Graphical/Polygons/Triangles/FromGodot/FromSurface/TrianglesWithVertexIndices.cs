using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Polygons.Triangles.FromGodot.
	FromSurface;

public sealed class TrianglesWithVertexIndices
	: EnumerableEnvelope<IPolygon>
{
	public TrianglesWithVertexIndices
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IEnumerable<IEnumerable<Int32>> triangles
	) : base
	(
		new SelectedByExpression<IEnumerable<Int32>, IPolygon>(
			triangles,
			vertices => Expression(mesh, surface, vertices))
	)
	{
	}

	private static IPolygon Expression
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IEnumerable<Int32> vertices
	) =>
	(
		new TriangleWithVertexIndices(mesh, surface, vertices)
	);
}