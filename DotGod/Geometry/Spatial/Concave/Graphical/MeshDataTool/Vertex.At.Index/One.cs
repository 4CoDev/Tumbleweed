using DotGod._Color;
using DotGod.Geometry.Spatial.Concave.Graphical.Vertex;
using Godot;

// ReSharper disable once CheckNamespace
namespace DotGod.Geometry.Spatial.Concave.Graphical.MeshDataTool.Vertex.At;

public sealed class One : Any
{
	public One
	(
		Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> mesh,
		Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	)
	{
		this.mesh = mesh;
		this.vertex = vertex;
	}

	public Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Real.Any> Translation =>
		new Index.Translation.As.Point.One(mesh, vertex);

	public Tumbleweed.Point.Spatial.Any<Tumbleweed.Number.Real.Any> Normal =>
		new Index.Normal.As.Point.One(mesh, vertex);

	public Tumbleweed.Scalar.Immutable.Any<Color> Color =>
		new ColorFromMeshDataTool(mesh, vertex);

	public Tumbleweed.Point.Planar.Any<Tumbleweed.Number.Real.Any> UV =>
		new Index.UV.As.Point.One(mesh, vertex);

	private readonly Tumbleweed.Scalar.Immutable.Any<Godot.MeshDataTool> mesh;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Int32> vertex;
}