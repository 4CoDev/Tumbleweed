using Godot;
using TumbleGD.Colors;
using TumbleGD.Numerics.Decimals.Planars.FromGodot;
using TumbleGD.Numerics.Decimals.Spatials.FromGodot;
using Tumbleweed.Numerics.Decimals;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.FromMeshDataTool;

public sealed class VertexWithIndex : IVertex
{
	public VertexWithIndex
	(
		IScalar<MeshDataTool> meshDataTool,
		IScalar<int> vertex
	)
	{
		this.meshDataTool = meshDataTool;
		this.vertex = vertex;
	}
	
	public ISpatial<IDecimal> Translation
	{
		get => new SpatialFromVector3(
			meshDataTool.Value().GetVertex(vertex.Value()));
	}
	
	public ISpatial<IDecimal> Normal
	{
		get => new SpatialFromVector3(
			meshDataTool.Value().GetVertexNormal(vertex.Value()));
	}

	public IScalar<Color> Color
	{
		get => new ColorFromMeshDataTool(meshDataTool, vertex);
	}

	public IPlanar<IDecimal> UV
	{
		get => new PlanarFromVector2(
			meshDataTool.Value().GetVertexUv(vertex.Value()));
	}

	private readonly IScalar<MeshDataTool> meshDataTool;
	
	private readonly IScalar<int> vertex;
}