using DotGod._Color;
using DotGod.Spatial.Graphical.Concave.Geometry.Normal.FromMeshDataTool;
using DotGod.Spatial.Graphical.Concave.Geometry.Translation.FromMeshDataTool;
using DotGod.Spatial.Graphical.Concave.Geometry.UV.FromMeshDataTool;
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.FromMeshDataTool;

public sealed class VertexWithIndex : IVertex
{
	public VertexWithIndex
	(Tumbleweed.Scalar.Immutable.Any<MeshDataTool> mesh, Tumbleweed.Scalar.Immutable.Any<Int32> vertex
	)
	{
		this.mesh = mesh;
		this.vertex = vertex;
	}

	public Tumbleweed.Point.Spatial.Any<Any> Translation =>
		new TranslationOfVertex(mesh, vertex);

	public Tumbleweed.Point.Spatial.Any<Any> Normal =>
		new NormalOfVertex(mesh, vertex);

	public Tumbleweed.Scalar.Immutable.Any<Color> Color =>
		new ColorFromMeshDataTool(mesh, vertex);

	public Tumbleweed.Point.Planar.Any<Any> UV =>
		new UVOfVertex(mesh, vertex);

	private readonly Tumbleweed.Scalar.Immutable.Any<MeshDataTool> mesh;
	
	private readonly Tumbleweed.Scalar.Immutable.Any<Int32> vertex;
}