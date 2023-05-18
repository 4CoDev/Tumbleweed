using DotGod.Colors;
using DotGod.Geometry.Spatial.Graphical.Normals.FromMeshDataTool;
using DotGod.Geometry.Spatial.Graphical.Translations.FromMeshDataTool;
using DotGod.Geometry.Spatial.Graphical.UVs.FromMeshDataTool;
using Godot;
using Tumbleweed.Numbers.Real;
using Tumbleweed.Points.Planar;
using Tumbleweed.Points.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Spatial.Graphical.Vertices.FromMeshDataTool;

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

	public Tumbleweed.Points.Spatial.IPoint<IReal> Translation =>
		new TranslationOfVertex(mesh, vertex);

	public Tumbleweed.Points.Spatial.IPoint<IReal> Normal =>
		new NormalOfVertex(mesh, vertex);

	public IScalar<Color> Color =>
		new ColorFromMeshDataTool(mesh, vertex);

	public Tumbleweed.Points.Planar.IPoint<IReal> UV =>
		new UVOfVertex(mesh, vertex);

	private readonly IScalar<MeshDataTool> mesh;
	
	private readonly IScalar<Int32> vertex;
}