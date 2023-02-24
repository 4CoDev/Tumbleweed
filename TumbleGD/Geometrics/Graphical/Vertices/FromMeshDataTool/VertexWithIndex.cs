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
	
	public ISpatial<IDecimal> Translation =>
		new SpatialFromVector3(
			meshDataTool.Value().GetVertex(vertex.Value()));

	public ISpatial<IDecimal> Normal =>
		new SpatialFromVector3(
			meshDataTool.Value().GetVertexNormal(vertex.Value()));

	public IScalar<Color> Color => new ColorFromMeshDataTool(meshDataTool, vertex);

	public IPlanar<IDecimal> UV =>
		new PlanarFromVector2(
			meshDataTool.Value().GetVertexUV(vertex.Value()));

	private readonly IScalar<MeshDataTool> meshDataTool;
	
	private readonly IScalar<int> vertex;
}