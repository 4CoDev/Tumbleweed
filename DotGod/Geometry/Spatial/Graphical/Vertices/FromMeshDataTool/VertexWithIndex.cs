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

	public ISpatial<IReal> Translation =>
		new TranslationOfVertex(mesh, vertex);

	public ISpatial<IReal> Normal =>
		new NormalOfVertex(mesh, vertex);

	public IScalar<Color> Color =>
		new ColorFromMeshDataTool(mesh, vertex);

	public IPlanar<IReal> UV =>
		new UVOfVertex(mesh, vertex);

	private readonly IScalar<MeshDataTool> mesh;
	
	private readonly IScalar<Int32> vertex;
}