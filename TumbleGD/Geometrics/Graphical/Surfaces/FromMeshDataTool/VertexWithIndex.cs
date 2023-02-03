using Godot;
using TumbleGD.Colors;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Measurement.Planars;
using Tumbleweed.Measurement.Spatials;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.FromMeshDataTool;

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
	
	public ISpatial<float> Translation
	{
		get => new SpatialFromVector3(
			meshDataTool.Value().GetVertex(vertex.Value()));
	}
	
	public ISpatial<float> Normal
	{
		get => new SpatialFromVector3(
			meshDataTool.Value().GetVertexNormal(vertex.Value()));
	}

	public IScalar<Color> Color
	{
		get => new ColorFromMeshDataTool(meshDataTool, vertex);
	}

	public IPlanar<float> UV
	{
		get => new PlanarFromVector2(
			meshDataTool.Value().GetVertexUv(vertex.Value()));
	}

	private readonly IScalar<MeshDataTool> meshDataTool;
	
	private readonly IScalar<int> vertex;
}