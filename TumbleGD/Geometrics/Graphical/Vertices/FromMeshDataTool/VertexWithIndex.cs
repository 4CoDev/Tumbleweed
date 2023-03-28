using Godot;
using TumbleGD.Colors;
using TumbleGD.Numerics.Decimals.Planars.FromGodot;
using TumbleGD.Numerics.Decimals.Spatials.FromGodot;
using Tumbleweed.Numerics.Fractional;
using Tumbleweed.Numerics.Planar;
using Tumbleweed.Numerics.Spatial;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Vertices.FromMeshDataTool;

public sealed class VertexWithIndex : IVertex
{
	public VertexWithIndex
	(
		IScalar<MeshDataTool> meshDataTool,
		IScalar<Int32> vertex
	)
	{
		this.meshDataTool = meshDataTool;
		this.vertex = vertex;
	}
	
	public ISpatial<IFractional> Translation =>
	(
		new SpatialFromVector3(
			meshDataTool.Value.GetVertex(vertex.Value))
	);

	public ISpatial<IFractional> Normal =>
	(
		new SpatialFromVector3(
			meshDataTool.Value.GetVertexNormal(vertex.Value))
	);

	public IScalar<Color> Color =>
		new ColorFromMeshDataTool(meshDataTool, vertex);

	public IPlanar<IFractional> UV =>
	(
		new PlanarFromVector2(
			meshDataTool.Value.GetVertexUV(vertex.Value))
	);

	private readonly IScalar<MeshDataTool> meshDataTool;
	
	private readonly IScalar<Int32> vertex;
}