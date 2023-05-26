using DotGod._Color;
using DotGod.Geometry.Spatial.Graphical.Normal.FromMeshDataTool;
using DotGod.Geometry.Spatial.Graphical.Translation.FromMeshDataTool;
using DotGod.Geometry.Spatial.Graphical.UV.FromMeshDataTool;
using Godot;
using Tumbleweed.Number.Real;
using Tumbleweed.Point.Spatial;
using Tumbleweed.Scalar;

namespace DotGod.Geometry.Spatial.Graphical.Vertex.FromMeshDataTool;

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

	public Tumbleweed.Point.Planar.IPoint<IReal> UV =>
		new UVOfVertex(mesh, vertex);

	private readonly IScalar<MeshDataTool> mesh;
	
	private readonly IScalar<Int32> vertex;
}