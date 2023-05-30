using DotGod._Color;
using DotGod.Spatial.Graphical.Concave.Geometry.Normal.FromMeshDataTool;
using DotGod.Spatial.Graphical.Concave.Geometry.Translation.FromMeshDataTool;
using DotGod.Spatial.Graphical.Concave.Geometry.UV.FromMeshDataTool;
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Scalar;
using Tumbleweed.Spatial.Point;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.FromMeshDataTool;

public sealed class VertexWithIndex : IVertex
{
	public VertexWithIndex
	(
		IScalar<MeshDataTool> mesh,
		IScalar<Int32> vertex
	)
	{
		this.mesh = mesh;
		this.vertex = vertex;
	}

	public IPoint<IReal> Translation =>
		new TranslationOfVertex(mesh, vertex);

	public IPoint<IReal> Normal =>
		new NormalOfVertex(mesh, vertex);

	public IScalar<Color> Color =>
		new ColorFromMeshDataTool(mesh, vertex);

	public Tumbleweed.Planar.Point.IPoint<IReal> UV =>
		new UVOfVertex(mesh, vertex);

	private readonly IScalar<MeshDataTool> mesh;
	
	private readonly IScalar<Int32> vertex;
}