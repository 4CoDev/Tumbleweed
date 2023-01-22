using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.WithGodot.Colors;

public sealed class ColorFromMeshDataTool : IScalar<Color>
{
	public ColorFromMeshDataTool
	(
		IScalar<MeshDataTool> meshDataTool,
		IScalar<int> vertex
	)
	{
		this.meshDataTool = meshDataTool;
		this.vertex = vertex;
	}

	public Color Value()
	{
		return meshDataTool.Value().GetVertexColor(vertex.Value());
	}
	
	private readonly IScalar<MeshDataTool> meshDataTool;
	
	private readonly IScalar<int> vertex;
}