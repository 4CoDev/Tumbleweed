using DotGod.Colors;
using DotGod.Geometrics.Graphical.Normals.FromMeshDataTool;
using DotGod.Geometrics.Graphical.Translations.FromMeshDataTool;
using DotGod.Geometrics.Graphical.UVs.FromMeshDataTool;
using Godot;
using DotGod.Numerics.Decimals.Planars.FromGodot;
using DotGod.Numerics.Decimals.Spatials.FromGodot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Vertices.FromMeshDataTool;

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

	public ISpatial<IFractional> Translation =>
		new TranslationOfVertex(mesh, vertex);

	public ISpatial<IFractional> Normal =>
		new NormalOfVertex(mesh, vertex);

	public IScalar<Color> Color =>
		new ColorFromMeshDataTool(mesh, vertex);

	public IPlanar<IFractional> UV =>
		new UVOfVertex(mesh, vertex);

	private readonly IScalar<MeshDataTool> mesh;
	
	private readonly IScalar<Int32> vertex;
}